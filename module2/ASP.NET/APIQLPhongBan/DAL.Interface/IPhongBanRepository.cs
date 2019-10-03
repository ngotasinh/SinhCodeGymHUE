using Domain;
using System;
using System.Collections.Generic;

namespace DAL.Interface
{
    public interface IPhongBanRepository
    {
        bool AddPhongBan(PhongBan phongBan);
        bool UpdatePhongBan(PhongBan phongBan);
        bool DeletePhongBan(int PhongID);
        IList<PhongBanView> GetAllPhongBan();
        PhongBanView GetPhongBanById(int PhongID);
    }
}
