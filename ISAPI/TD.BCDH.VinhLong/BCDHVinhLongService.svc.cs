using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;
using TD.BCDH.VinhLong.APIResults;
using TD.BCDH.VinhLong.Models;
using TD.BCDH.VinhLong.ViewModels;

namespace TD.BCDH.VinhLong
{
    [AspNetCompatibilityRequirements(
    RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public partial class BCDHVinhLongService : IBCDHVinhLongService
    {
        public APIResult AddListDonViGiaoDuc(List<DonVi> listDonViGiaoDuc)
        {
            throw new NotImplementedException();
        }

        public string HelloWorld()
        {
            throw new NotImplementedException();
        }

        public APIResult LayDanhSachApiDashboard(string fields)
        {
            throw new NotImplementedException();
        }

        public ChartOutput Loc(ChartInput input)
        {
            throw new NotImplementedException();
        }

        public ChartOutput Loc1(ChartInputByMonth input)
        {
            throw new NotImplementedException();
        }

        public bool RandomOffice(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public bool TruncateVanBan()
        {
            throw new NotImplementedException();
        }
    }
}
