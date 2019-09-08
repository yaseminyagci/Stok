using StokEkstresi.Data.Context;
using StokEkstresi.Domain.WebUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokEkstresi.Core;
using StokEkstresi.Domain.Entity;
using StokEkstresi.Domain.WebUI.Filter;
using StokEkstresi.Core.Extensions;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity;

namespace StokEkstresi.Service
{
    public class StokEkstresiService
    {

        public ServiceResultModel<List<ProcedureVM>> GetAllStokDefinition(STKFilter filter)
        {
            List<ProcedureVM> resultList = new List<ProcedureVM>();




            using (var context = new EFBookingContext())
            {
                if (filter.MalKodu == null || filter.MalAdı == null)
                {
                    filter.MalKodu = "10087 SİEMENS";
                    filter.MalAdı = "5SQ2160-2YA40 B 40A  OTOMATİK SİGORTA";
                }
                var MalKodu = new SqlParameter("@MalKodu", filter.MalKodu);
                var result = context.Database.SqlQuery<ProcedureVM>("Mal_Procedure_ @MalKodu", MalKodu).ToList();

                resultList = result.ToList();

                return ServiceResultModel<List<ProcedureVM>>.OK(resultList);


            }
        }
    }
}




