using Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuantosLivrosLiDesktop
{
    public partial class LivroCRUD : frmCRUD
    {
        #region variáveis
        public List<LivroDAL> Registros
        {
            get
            {
                if (_registros == null)
                    _registros = new List<LivroDAL>();
                return _registros;
            }

            set
            {
                _registros = value;
            }

        }
        private List<LivroDAL> _registros;

        public ClassLivroController ObjController
        {
            get
            {
                if (_objcontroller == null)
                    _objcontroller = new ClassLivroController();
                return _objcontroller;
            }

            set
            {
                _objcontroller = value;
            }
        }
        private ClassLivroController _objcontroller;
        #endregion

        public LivroCRUD()
        {
            InitializeComponent();            
            BindingForm();
            MontaComboboxfiltros(new LivroDAL());
            MontaLookups();
            lblSerie.Visible = false;
            cIdSerie.Visible = false;
        }

        private void MontaLookups()
        {
            //https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRepositoryRepositoryItemLookUpEditBase_DataSourcetopic
            /*ClassSerieController Series = new ClassSerieController();
            List<SerieDAL> ListaSeries = Series.getRegistros<SerieDAL>("ID", String.Empty);  */          
        }

        private void BindingForm()
        {
            bindingSource.DataSource = Registros;
            bindingNavigator.BindingSource = bindingSource;
            gridView.DataSource = bindingSource;

            cIdLivro.DataBindings.Add("Text", bindingSource, "idLivro");
            cNome.DataBindings.Add("Text", bindingSource, "nome");
            Binding b = new Binding("Value", bindingSource, "dt_inicio", true);
            cDt_inicio.DataBindings.Add(b);
            Binding b1 = new Binding("Value", bindingSource, "dt_final", true);
            cDt_final.DataBindings.Add(b1);
            //cIdSerie.DataBindings.Add("Value", bindingSource, "idSerie");
            cObs.DataBindings.Add("Text", bindingSource, "obs");
            HideColumnsLancamento();
        }

        private void HideColumnsLancamento()
        {
            gridView.Columns["obs"].Visible = false;
        }

        protected override void DoFilter()
        {
            Registros.Clear();

            Registros = ObjController.getRegistros<LivroDAL>(itemSelecionadoCombobox, txtFiltro.Text);
            bindingSource.DataSource = Registros;
            bindingSource.ResetBindings(false);
        }

        protected override void DoSave()
        {
            ObjController.Save<LivroDAL>(CreateObjLancamento(), IsInsert);
        }

        protected override void DoDelete()
        {
            ObjController.Delete<LivroDAL>(CreateObjLancamento());
        }

        private LivroDAL CreateObjLancamento()
        {
            return
                new LivroDAL
                {
                    idLivro = Convert.ToInt16(cIdLivro.Text),
                    nome = cNome.Text,
                    dt_inicio = Convert.ToDateTime(cDt_inicio.Value),
                    dt_final = Convert.ToDateTime(cDt_final.Value),
                    obs = cObs.Text
                };
        }
    }
}
