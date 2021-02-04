using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection;


namespace SistemaFinanceiro.Helper
{
    public static class HtmlCustom
    {
        public static TValue GetAttributeValue<TAttribute, TValue>(this MemberInfo member, Func<TAttribute, TValue> getter, TValue defaultValue)
            where TAttribute : Attribute
        {
            var attribute = member.GetCustomAttribute<TAttribute>();
            return attribute.GetValue(getter, defaultValue);
        }

        public static TValue GetValue<TAttribute, TValue>(this TAttribute attribute, Func<TAttribute, TValue> getter, TValue defaultValue)
            where TAttribute : Attribute
        {
            return attribute == null
                ? defaultValue
                : getter(attribute);
        }
        public static void AddCssClasses(this TagBuilder builder, params string[] cssClasses)
        {
            foreach (var cssClass in cssClasses)
                builder.AddCssClass(cssClass);
        }
        public static IHtmlContent EditBootstrapFor<TModel, TValue>(this IHtmlHelper<TModel> self, Expression<Func<TModel, TValue>> expression, int tudoTamanho = 0, int inputTamanho = 0)
        {
            var member = (expression.Body as MemberExpression).Member;

            //Tenta definir o valor de maxLength a partir do valor do InoutMaskAttribute
            var inputMask = member.GetCustomAttribute<InputMaskAttribute>();
            var InputAttribute = member.GetCustomAttribute<InputAttributeAux>();

            var mainDiv = new TagBuilder("div");

            if (inputMask != null && inputMask.Mask == "99/99/9999")
                mainDiv.AddCssClasses("form-group", "umadata", $"div{(expression.Body as MemberExpression).Member.Name }", $"col-xs-{tudoTamanho} pull-right");
            else
                mainDiv.AddCssClasses("form-group", $"div{(expression.Body as MemberExpression).Member.Name }", $"col-xs-{tudoTamanho}");

            bool valorMonetario = (inputMask != null && inputMask.Mask == "#.##0,00");
            // Adiciona o label do input na div principal.
            mainDiv.InnerHtml.AppendHtml(self.LabelFor(expression));

            // Incluir o valor " *" na div principal se o membro possuir RequiredAttribute.
            if (member.GetCustomAttribute<RequiredAttribute>() != null)
                mainDiv.InnerHtml.Append(" *");


            // Inclui ajuda no div principal se for definido o attributo AjudaAttribute e a propriedade Ajuda não for null ou somente espaços em branco.
            var ajuda = member.GetAttributeValue<AjudaAttribute, string>((a) => a.Ajuda, string.Empty);

            if (!string.IsNullOrWhiteSpace(ajuda))
            {
                var abbr = new TagBuilder("abbr");



                abbr.Attributes.Add("data-toggle", "tooltip");
                abbr.Attributes.Add("data-placement", "top");
                abbr.Attributes.Add("title", ajuda);

                var i = new TagBuilder("i");
                i.AddCssClasses("fa", "fa-question-circle");
                abbr.InnerHtml.AppendHtml(i);


                mainDiv.InnerHtml.AppendHtml(abbr);
            }


            // Define o tamanho máximo do input com o valor default.
            var maxLength = 200;

            // Tenta definir o valor de maxLength a partir do valor em StringLengthAttribute 
            var stringLength = member.GetCustomAttribute<StringLengthAttribute>();


            if (stringLength != null)
            {
                maxLength = stringLength.MaximumLength;
            }
            if (inputMask != null && inputMask.Mask == "99/99/9999")
            {
                maxLength = 10;
            }
            else if (inputMask != null && inputMask.Mask == "99/9999")
            {
                maxLength = 7;
            }
            // Declara a div do input.
            var divInput = new TagBuilder("div");
            divInput.AddCssClasses("input-group", $"col-xs-{inputTamanho}", "divInput");

            if (InputAttribute != null && InputAttribute.TemInicio)
            {
                divInput.InnerHtml.AppendHtml($"<span class='input-group-addon' id='span{(expression.Body as MemberExpression).Member.Name}'>{InputAttribute.Inicio}</span>");
            }

            string Tipo = "text";

            if (InputAttribute != null && InputAttribute.TemTypo)
            {
                Tipo = InputAttribute.Type.ToString();
                if (InputAttribute.Type.ToString() == "number")
                {
                    maxLength = 0;
                }
            }

            if (member.GetCustomAttribute<DataTypeAttribute>() != null)
            {
                Tipo = member.GetAttributeValue<DataTypeAttribute, string>((a) => a.DataType.ToString(), string.Empty);
            }

            // Define os atributos do input.
            var inputAttributes = new Dictionary<string, object>
            {
                { "id", (expression.Body as MemberExpression).Member.Name },
                { "name", (expression.Body as MemberExpression).Member.Name },
                { "type", Tipo }
            };

            if (inputMask != null && inputMask.IsReverso)
            {
                inputAttributes.Add("data-mask-reverse", "True");
                inputAttributes.Add("data-mask", inputMask.Mask);
            }

            if (valorMonetario)
            {
                inputAttributes.Add("class", "form-control text-right umValorMonetario");
                inputAttributes.Add("onKeyPress", "return(FormataMoeda(this,'.',',',event))");
            }
            else
            {
                inputAttributes.Add("class", "form-control");
            }

            if (InputAttribute != null && InputAttribute.TemValorMaximo)
            {
                inputAttributes.Add("max", InputAttribute.ValorMaximo);
            }
            if (InputAttribute != null && InputAttribute.TemValorMinimo)
            {
                inputAttributes.Add("min", InputAttribute.ValorMinimo);
            }
            if (maxLength > 0)
            {
                inputAttributes.Add("maxlength", maxLength);
            }

            // Adiciona o input na div dele.
            divInput.InnerHtml.AppendHtml(self.TextBoxFor(expression, inputAttributes));

            if (InputAttribute != null && InputAttribute.TemFinal)
            {
                divInput.InnerHtml.AppendHtml($"<span class='input-group-addon' id='span{(expression.Body as MemberExpression).Member.Name}'>{InputAttribute.Final}</span>");
            }
            // Adiciona a div do input na div principal.
            mainDiv.InnerHtml.AppendHtml(divInput);

            // Adiciona o span na div principal.
            var span = new TagBuilder("span");
            span.AddCssClasses("field-validation-valid", "text-danger");
            span.Attributes.Add("data-valmsg-for", member.Name);
            span.Attributes.Add("data-valmsg-replace", "true");

            mainDiv.InnerHtml.AppendHtml(span);


            return mainDiv;
        }
    }
}
