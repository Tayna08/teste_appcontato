using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AppWPF.Contexto
{
    internal class Contato
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public double Telefone { get; set; }
        public DatePicker Data { get; set; }
    }
}
