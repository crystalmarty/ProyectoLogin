using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectofinalSAT
{
    public partial class Registro: Form
    {
        Usuario usuario;
        public FormularioBienvenida(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FormularioBienvenida_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuario.nombre;
        }

    }
}

        public Registro()
        {
            InitializeComponent();
        }
    }
}
