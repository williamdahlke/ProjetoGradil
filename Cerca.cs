using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGradil
{

    public class Cerca
    {
        public Cerca()
        {
            this.comprimento = 0;
            this.altura = 0;
            this.cor = "";
            this.comprimentoCalculado = 0;
            this.diferencaComprimento = 0;
        }

        private double comprimento;
        private double altura;
        private string cor;
        private double comprimentoCalculado;
        private double diferencaComprimento;

        public List<Acessorio> Acessorio;

        public void setComprimento(double pComprimento)
        {
            this.comprimento = pComprimento;
        }

        public double getComprimento()
        {
            return this.comprimento;
        }

        public void setAltura(double pAltura)
        {
            this.altura = pAltura;
        }

        public double getAltura()
        {
            return this.altura;
        }

        public void setCor(string pCor)
        {
            this.cor = pCor;
        }

        public string getCor()
        {
            return this.cor;
        }

        public double CalcularComprimento(double pComprimentoPadrao)
        {
            if (this.comprimento < pComprimentoPadrao)
            {
                this.comprimentoCalculado = pComprimentoPadrao;
            }
            else
            {
                this.comprimentoCalculado = (Math.Ceiling(this.comprimento/pComprimentoPadrao)) * pComprimentoPadrao;
            }
            return this.comprimentoCalculado;
        }

        public double CalcularDiferenca()
        {
            return this.diferencaComprimento = this.comprimentoCalculado - this.comprimento;
        }
    }
}
