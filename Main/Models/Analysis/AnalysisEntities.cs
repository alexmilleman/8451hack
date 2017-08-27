using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Main.Models.Analysis
{
    public class AnalysisEntities
    {
        public AnalysisEntities()
        {
			ProductRecomendations = new List<ProductRecomendation>{
				new ProductRecomendation(){
					ProductId = 1,
                    RecomendedProductIdsJson = JsonConvert.SerializeObject(new List<int>(){
                        1, 3, 55, 10
                    })
				},
				new ProductRecomendation(){
					ProductId = 2,
					RecomendedProductIdsJson = JsonConvert.SerializeObject(new List<int>(){
						33, 1, 99, 2
					})
				},
				new ProductRecomendation(){
					ProductId = 3,
					RecomendedProductIdsJson = JsonConvert.SerializeObject(new List<int>(){
						2, 4, 77, 33
					})
				},
            };
        }


        public List<ProductRecomendation> ProductRecomendations {get;set;}
    }
}
