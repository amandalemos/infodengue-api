namespace InfoDengue.Controllers
{
    public class Relatorio
    {

        public long data_iniSE { get; set; }
        public int SE { get; set; }
        public int casos_est { get; set; }
        public int casos_est_min { get; set; }
        public int casos_est_max { get; set; }
        public int casos { get; set; }
        public double p_rt1 { get; set; }
        public double p_inc100k { get; set; }
        public int Localidade_id { get; set; }
        public int nivel { get; set; }
        public long id { get; set; }
        public string versao_modelo { get; set; }
        public int tweet { get; set; }
        public double Rt { get; set; }
        public int pop { get; set; }
        public double tempmin { get; set; }
        public double umidmax { get; set; }
        public int receptivo { get; set; }
        public int transmissao { get; set; }
        public int nivel_inc { get; set; }
        public double umidmed { get; set; }
        public double umidmin { get; set; }
        public double tempmed { get; set; }
        public double tempmax { get; set; }
        public object casprov { get; set; }  // Pode ser null, por isso é 'object'
        public object casprov_est { get; set; } // Pode ser null
        public object casprov_est_min { get; set; } // Pode ser null
        public object casprov_est_max { get; set; } // Pode ser null
        public object casconf { get; set; } // Pode ser null
        public int notif_accum_year { get; set; }



        public object CodigoIBGE { get; internal set; }
        public object Arbovirose { get; internal set; }
        public object SemanaInicio { get; internal set; }
        public object AnoInicio { get; internal set; }
        public object SemanaFim { get; internal set; }
        public object AnoFim { get; internal set; }
    }
}