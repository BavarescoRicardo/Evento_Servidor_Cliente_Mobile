using Festival.or;
using Festival.bo;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Servidor.Models;
using System.Windows.Forms;

namespace Servidor.Controllers
{
    // url              http://localhost:49890/api/juri          post http://localhost:49890/api/juri?nota=7.4      get http://localhost:49890/api/juri

    public class juriController : ApiController
    {
        
        private static List<Jurado> juri = new List<Jurado>();

        public List<Jurado> Get()
        {
            JuradoBo bo = new JuradoBo();
            IList<Festival.or.Jurado> lista = bo.Listar();

            juri = lista.ToList();
            return juri;
        }

        public void Post(double nota)
        {
            MessageBox.Show(nota.ToString());
        }
    }
}
