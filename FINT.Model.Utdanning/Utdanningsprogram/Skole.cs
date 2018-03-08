// Built from tag v0.99.9

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Utdanning.Utdanningsprogram
{
	public class Skole : Enhet {
		public enum Relasjonsnavn
        {
			ORGANISASJON,
			FAG,
			SKOLEEIERTYPE,
			VIGOREFERANSE,
			UTDANNINGSPROGRAM,
			UTDANNINGSFORHOLD
        }
        
	
		public string Domenenavn { get; set; }
		public string JuridiskNavn { get; set; }
		public string Navn { get; set; }
		public Identifikator Skolenummer { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}
