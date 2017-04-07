using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImobsyncDesktop
{

    public class ImovelDTO
    {
        public ImovelDTO() {
            Fotos = new List<string>();
            Cadastrado = false;
        }

        public int IdImovel
        {
            get;
            set;
        }

        public string Codigo
        {
            get;
            set;
        }

        public string Slug
        {
            get;
            set;
        }

        public string Negocio
        {
            get;
            set;
        }

        public string Titulo
        {
            get;
            set;
        }

        public string Tipo
        {
            get;
            set;
        }

        public string Cep
        {
            get;
            set;
        }

        public string Uf
        {
            get;
            set;
        }

        public string Cidade
        {
            get;
            set;
        }

        public string Bairro
        {
            get;
            set;
        }

        public string Endereco
        {
            get;
            set;
        }

        public string Complemento
        {
            get;
            set;
        }

        public int Quartos
        {
            get;
            set;
        }

        public int Suites
        {
            get;
            set;
        }

        public int Banheiros
        {
            get;
            set;
        }

        public int Garagens
        {
            get;
            set;
        }

        public double AreaUtil
        {
            get;
            set;
        }

        public double Preco
        {
            get;
            set;
        }

        public string Descricao
        {
            get;
            set;
        }

        public IList<string> Fotos
        {
            get;
            set;
        }

        public bool OlxSituacao
        {
            get;
            set;
        }

        public bool Cadastrado
        {
            get;
            set;
        }
    }
}
