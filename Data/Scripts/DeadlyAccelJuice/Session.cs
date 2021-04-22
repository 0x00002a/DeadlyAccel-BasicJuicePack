 using System.Collections.Generic;
using System;
using Natomic.DeadlyAccel.API;

namespace Natomic.DeadlyAccelJuice {
 [MySessionComponentDescriptor(MyUpdateOrder.NoUpdate, 1)]
    public class Session : MySessionComponentBase
    {
        public static Session Instance;

        private DeadlyAccelAPI api = new DeadlyAccelAPI();

        public override void LoadData()
        {
            
            Instance = this;

            api.Init(OnDeadlyAccelLoad);
        }
        private void OnDeadlyAccelLoad(DeadlyAccelAPI api) {
           
            api.RegisterJuiceDefinition(new JuiceDefinition(){
                SubtypeId = "NI_DAJ_JuiceLvl_1_Bottle",
                ConsumptionRate = 0.01f,
				ToxicityPerMitagated = 2f,
				ToxicityDecay = 0.1f,	
				Ranking = 10,
            });
            
        }
		protected override void UnloadData() {
			api.Dispose();
			Instance = null;
		}
    }
 }
 