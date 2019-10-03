using BAL.Interface;
using DAL.Interface;
using Domain;
using System;
using System.Collections.Generic;

namespace BAL
{
    public class PhongBanService : IPhongBanService
    {
        IPhongBanRepository _PhongBanRepository;
        public PhongBanService(IPhongBanRepository PhongbanRepository)
        {
            _PhongBanRepository = PhongbanRepository;
        }
        public bool AddPhongBan(PhongBan phongBan)
        {
            return _PhongBanRepository.AddPhongBan(phongBan);
        }

        public bool DeletePhongBan(int PhongID)
        {
            return _PhongBanRepository.DeletePhongBan(PhongID);
        }

        public IList<PhongBanView> GetAllPhongBan()
        {
            return _PhongBanRepository.GetAllPhongBan();
        }

        public PhongBanView GetPhongBanById(int PhongID)
        {
            return _PhongBanRepository.GetPhongBanById(PhongID);
        }

        public bool UpdatePhongBan(PhongBan phongBan)
        {
            return _PhongBanRepository.UpdatePhongBan(phongBan);
        }
    }
}
