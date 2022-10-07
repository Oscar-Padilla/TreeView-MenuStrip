using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace TreeView___MenuStrip
{
    public partial class Pantalla2 : Form
    {
        public Pantalla2()
        {
            InitializeComponent();
            this.Height = 386;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Pantalla1 P1 = new Pantalla1();
            P1.Show();
        }

        private void insertarRaízToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Height = 478;
            tBElemento.PlaceholderText = "Ingresa la raíz";
            tBElemento.Visible = true;
            btnAddDel.Visible = true;
        }

        private void btnAddDel_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Add(tBElemento.Text);
            this.Height = 386;
            tBElemento.Visible = false;
            tBElemento.Text = "";
            btnAddDel.Visible = false;
        }

        private void insertarNodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Height = 478;
            tBElemento.PlaceholderText = "Ingresa el nodo";
            tBElemento.Visible = true;
            btnAgregarNodo.Visible = true;
        }

        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {
            treeView.SelectedNode.Nodes.Add(tBElemento.Text);
            this.Height = 386;
            tBElemento.Visible = false;
            tBElemento.Text = "";
            btnAgregarNodo.Visible = false;
        }

        private void eliminarElementoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Height = 434;
            btnEliminarNodo.Visible = true;
        }

        private void btnEliminarNodo_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Remove(treeView.SelectedNode);
            this.Height = 386;
            btnEliminarNodo.Visible = false;
        }

        private void eliminarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var siono = MessageBox.Show("¿Seguro que quieres eliminar todo?", "Eliminar Todo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (siono == DialogResult.Yes)
            {
                treeView.Nodes.Clear();
            }
        }
        //Aqui empieza XML para guardar y cargar el treeview
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TreeView Guradado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            exportToXml(treeView, @"D:\PracticasVS\Practicas_VisualStudio\TreeView - MenuStrip\bin\Debug\prueba.xml");
        }
        StreamWriter sr;
        public void exportToXml(TreeView tv, string filename)
        {
            sr = new StreamWriter(filename, false, System.Text.Encoding.UTF8);
            sr.WriteLine("<" + tv.Nodes[0].Text + ">");
            foreach (TreeNode node in tv.Nodes)
            {
                saveNode(node.Nodes);
            }
            sr.WriteLine("</" + tv.Nodes[0].Text + ">");
            sr.Close();
        }

        private void saveNode(TreeNodeCollection tnc)
        {
            foreach (TreeNode node in tnc)
            {

                if (node.Nodes.Count > 0)
                {
                    sr.Write("<" + node.Text + ">");
                    saveNode(node.Nodes);
                    sr.WriteLine("</" + node.Text + ">");
                }
                else
                    sr.Write(node.Text);
            }
        }

        public void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument dom = new XmlDocument();
                dom.Load(@"D:\PracticasVS\Practicas_VisualStudio\TreeView - MenuStrip\bin\Debug\prueba.xml");

                treeView.Nodes.Clear();
                treeView.Nodes.Add(new TreeNode(dom.DocumentElement.Name));
                TreeNode tNode = new TreeNode();
                tNode = treeView.Nodes[0];

                AddNode(dom.DocumentElement, tNode);
                treeView.ExpandAll();
            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;

            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }

        private void cómoSeUsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}