using Application.Helpers;
using Application.Interface;
using Application.Model;
using Domain.Entities;
using Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Application
{
    public class UsarioApp : IUsarioApp
    {
        private readonly IUsuarioService _usuario;

        public UsarioApp(IUsuarioService usuario)
        {
            _usuario = usuario;
        }

        public List<DadosUsuarioVM> BuscaTodosUsuarios()
        {
            List<DadosUsuarioVM> lista = new List<DadosUsuarioVM>();
            DadosUsuarioVM usu = new DadosUsuarioVM();
            var listaUsuario = _usuario.BuscaTodosUsuariosAtivos();
            foreach(var item in listaUsuario)
            {
                usu = new DadosUsuarioVM();
                usu.codigoUsuario = item.CODUSUARIO;
                usu.nomeUsuario = item.NMUSUARIO;
                usu.Email = item.EMAIL;
                usu.dataNascimento = item.dtNascimento.ToShortDateString();
                usu.Cpf = Geral.FormataCPFCnPj(item.CPF);
                usu.dataCadastro = item.dtNascimento.ToShortDateString();
                usu.Login = item.LOGIN;

                lista.Add(usu);
            }

            return lista;
        }

        public DadosUsuarioVM BuscaUsuarioByID(int codigoUsuario)
        {
            DadosUsuarioVM usu = new DadosUsuarioVM();

            if (codigoUsuario == 0)
                return new DadosUsuarioVM();

            var dadosUsuario = _usuario.BuscaUsuarioByID(codigoUsuario);

            usu.codigoUsuario = dadosUsuario.CODUSUARIO;
            usu.nomeUsuario = dadosUsuario.NMUSUARIO;
            usu.Email = dadosUsuario.EMAIL;
            usu.dataNascimento = dadosUsuario.dtNascimento.ToShortDateString();
            usu.Cpf = Geral.FormataCPFCnPj(dadosUsuario.CPF);
            usu.dataCadastro = dadosUsuario.dtNascimento.ToShortDateString();
            usu.Login = dadosUsuario.LOGIN;

            return usu;

        }

        public IDictionary<bool, string> DesativaUsuario(int codigoUsuario)
        {
            Dictionary<bool, string> Result = new Dictionary<bool, string>();
            try
            {
                _usuario.DesativaUsuario(codigoUsuario);

                Result.Add(true, "Usuario desativado com sucesso");
            }
            catch (Exception ex)
            {
                Result.Add(false, ex.Message);
            }

            return Result;
        }

        public IDictionary<bool, string> SalvarUsuario(DadosUsuarioVM model)
        {
            Dictionary<bool, string> Result = new Dictionary<bool, string>();
            try
            {
                TBUsuario usu = new TBUsuario();
                if (model.codigoUsuario > 0)
                {
                    usu = _usuario.BuscaUsuarioByID(model.codigoUsuario);
                }
                else
                {
                    usu.ATIVO = true;
                    usu.dtCadastro = DateTime.Now;
                }

                usu.NMUSUARIO = model.nomeUsuario;
                usu.LOGIN = model.Login;
                usu.SENHA = model.Password;
                usu.dtNascimento = Convert.ToDateTime(model.dataNascimento);
                usu.CPF = Geral.RemoveCaracteres(model.Cpf);
                usu.EMAIL = model.Email;

                if (model.codigoUsuario > 0)
                {
                    _usuario.AlteraUsuario(usu);
                }
                else
                {
                    _usuario.IncluiUsuario(usu);
                }
                Result.Add(true, "Usuario salvo com sucesso");
            }
            catch (Exception ex)
            {
                Result.Add(false, ex.Message);
            }

            return Result;
        }
    }
}
