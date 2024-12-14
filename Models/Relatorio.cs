public class Relatorio
{
    public long Id { get; set; }
    public int SE { get; set; }
    public double? CasosEst { get; set; }
    public double? CasosEstMin { get; set; }
    public double? CasosEstMax { get; set; }
    public double? Casos { get; set; }
    public double? Prt1 { get; set; }
    public double? PInc100k { get; set; }
    public double? Pop { get; set; }
    public double? TempMin { get; set; }
    public double? UmidMax { get; set; }
    public double? UmidMed { get; set; }
    public double? UmidMin { get; set; }
    public double? TempMed { get; set; }
    public double? TempMax { get; set; }
    public double? Rt { get; set; }
    public int Nivel { get; set; }
    public double? Tweet { get; set; }
    public int Receptivo { get; set; }
    public int Transmissao { get; set; }
    public int NivelInc { get; set; }
    public double? CasProv { get; set; }
    public double? CasConf { get; set; }
    public long DataIniSE { get; set; }

    // Adicione as propriedades ausentes
    public string CodigoIBGE { get; set; }
    public string Arbovirose { get; set; }
    public int SemanaInicio { get; set; }
    public int SemanaFim { get; set; }
    public int AnoInicio { get; set; }
    public int AnoFim { get; set; }

    // Propriedades obrigatórias com valores iniciais no construtor
    public string VersaoModelo { get; set; }
    public double NotifAccumYear { get; set; }

    // Construtor para inicializar as propriedades obrigatórias
    public Relatorio(string versaoModelo, int semanaFim, int anoFim)
    {
        VersaoModelo = versaoModelo ?? throw new ArgumentNullException(nameof(versaoModelo)); // Garantir que não seja nulo
        SemanaFim = semanaFim;
        AnoFim = anoFim;
    }
}
