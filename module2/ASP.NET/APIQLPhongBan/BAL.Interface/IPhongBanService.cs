using Domain;
using System;
using System.Collections.Generic;

namespace BAL.Interface
{
    public interface IPhongBanService
    {
        bool AddPhongBan(PhongBan phongBan);
        bool UpdatePhongBan(PhongBan phongBan);
        bool DeletePhongBan(int PhongID);
        IList<PhongBanView> GetAllPhongBan();
        PhongBanView GetPhongBanById(int PhongID);
    }
}
