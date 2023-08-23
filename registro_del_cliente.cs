registro de los clientes
using System; 
using System.Collections.Generic; 
using System.ComponentModel; 
using System.Data; 
using System.Drawing; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Windows.Forms; 
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button; 
using static System.Windows.Forms.VisualStyles.VisualStyleElement; 
 
namespace DENTISTA 
{ 
    public partial class Form1 : Form 
    { 
        public int selectRow; 
        List<ClRegistroPaciente1> registro = new List<ClRegistroPaciente1>(); 
        public Form1() 
        { 
            InitializeComponent(); 
            this.toolTip1.SetToolTip(this.textBox1, "Codigo Paciente"); 
            this.toolTip1.SetToolTip(this.textBox2, " Nombre Paciente"); 
            this.toolTip1.SetToolTip(this.textBox3, "Apellido Paciente"); 
            this.toolTip1.SetToolTip(this.dateTimePicker1, "Fecha Ingreso"); 
        }