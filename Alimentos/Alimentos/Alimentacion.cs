using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alimentos
{
    public partial class Alimentacion : Form
    {
        public Alimentacion()
        {
            InitializeComponent();
            this.Dat1.AutoGenerateColumns = false;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            using (Model1Container Conexion = new Model1Container())
            {
                if (string.IsNullOrEmpty(this.Identificacion.Text))
                {
                    MessageBox.Show("Ingrese Un Codigo");
                }
                else
                {
                    int id = Convert.ToInt32(this.Identificacion.Text);
                    var Alimento = Conexion.ProductosSet
                            .Where(a => a.Codigo == id)
                            .FirstOrDefault();

                    if (Alimento == null)
                    {
                        MessageBox.Show("No Ha Resultados");
                        this.txt2.Text = string.Empty;
                        this.NUM1.Value = this.NUM1.Minimum;
                        this.txt3.Text = string.Empty;
                        this.txt5.Text = string.Empty;
                    }
                    else
                    {
                        this.txt2.Text = Alimento.Descripcion;
                        this.NUM1.Value = Alimento.Cantidad;
                        this.txt3.Text = Alimento.Valor.ToString();
                        this.txt5.Text = Alimento.Categoria.ToString();
                    }
                }
            }
        }


        private void bt2_Click(object sender, EventArgs e)
        {
            using (Model1Container Conexion = new Model1Container())
            {
                if (string.IsNullOrEmpty(this.Identificacion.Text))
                {
                    MessageBox.Show("Ingrese Un Codigo");
                }
                else
                {
                    int id = Convert.ToInt32(this.Identificacion.Text);
                    var Alimento = Conexion.ProductosSet
                            .Where(a => a.Codigo == id)
                            .FirstOrDefault();

                    if (Alimento == null)
                    {
                        MessageBox.Show("No Ha Resultados");
                        this.txt2.Text = string.Empty;
                        this.NUM1.Value = this.NUM1.Minimum;
                        this.txt3.Text = string.Empty;
                        this.txt5.Text = string.Empty;
                    }
                    else
                    {
                        try
                        {
                            this.txt2.Text = Alimento.Descripcion;
                            this.NUM1.Value = Alimento.Cantidad;
                            this.txt3.Text = Alimento.Valor.ToString();
                            this.txt5.Text = Alimento.Categoria.ToString();
                        }
                        catch
                        {
                            MessageBox.Show("No Se Ha Podido Eliminar");
                        }
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CampoValidos())
            {
                using (Model1Container Conexion = new Model1Container())
                {
                    int id = Convert.ToInt32(this.Identificacion.Text);
                    var Alimento = Conexion.ProductosSet
                            .Where(a => a.Codigo == id)
                            .FirstOrDefault();

                    if (Alimento == null)
                    {
                        MessageBox.Show("No Es Posible Actualizar Un Alimento No Registrado");

                    }
                    else
                    {
                        Alimento.Descripcion = this.txt2.Text;
                        Alimento.Valor = Convert.ToInt32(this.txt3.Text);
                        Alimento.Categoria = Convert.ToInt32(this.txt5.Text);
                        Alimento.Cantidad = Convert.ToInt32(this.NUM1.Value);

                        try
                        {
                            Conexion.SaveChanges();

                            bt5_Click(sender, e);
                            MessageBox.Show("Alimento Actualizado");

                        }
                        catch
                        {
                            MessageBox.Show("No Se Ha Podido Actualizar");
                        }
                    }
                }
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (CampoValidos())
            {
                Productos Alimento = new Productos();
                Alimento.Codigo = Convert.ToInt32(this.Identificacion.Text);
                Alimento.Descripcion = this.txt2.Text;
                Alimento.Valor = Convert.ToInt32(this.txt3.Text);
                Alimento.Categoria = Convert.ToInt32(this.txt5.Text);
                Alimento.Cantidad =Convert.ToInt32(this.NUM1.Value);

                using (Model1Container Conexion = new Model1Container())
                {
                    Conexion.ProductosSet.Add(Alimento);
                    try
                    {
                        Conexion.SaveChanges();
                        bt5_Click(sender, e);
                        MessageBox.Show("Alimento Agregado");
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("No Se Puede Insertar El Alimento");
                    }
                }
            }
        }

        private bool CampoValidos()
        {
            if (string.IsNullOrEmpty(this.Identificacion.Text))
            {
                MessageBox.Show("Ingrese El Codigo");
                return false;
            }
            if (string.IsNullOrEmpty(this.Identificacion.Text))
            {
                MessageBox.Show("Ingrese La Descripcion");
                return false;
            }
            if (string.IsNullOrEmpty(this.Identificacion.Text))
            {
                MessageBox.Show("Ingrese Valor");
                return false;
            }
            if (string.IsNullOrEmpty(this.Identificacion.Text))
            {
                MessageBox.Show("Ingrese Cantidad");
                return false;
            }
            if (string.IsNullOrEmpty(this.Identificacion.Text))
            {
                MessageBox.Show("Ingrese Categoria");
                return false;
            }
            return true;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            using (Model1Container Conexion = new Model1Container())
            {
                try
                {
                    this.Dat1.DataSource = Conexion.ProductosSet.ToList();
                }
                catch(Exception x)
                {
                    MessageBox.Show(x.StackTrace);
                }
                
            }
        }
    }
   
    }

