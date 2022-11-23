using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Services
{
    public class DonorService
    {
        public static List<DonorDTO> Get() {
            var data = DataAccessFactory.DonorDataAccess().Get();
            var config = new MapperConfiguration(cfg => { 
                cfg.CreateMap<Donor, DonorDTO>();   
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<List<DonorDTO>>(data);
            return rt;  

        }
        public static DonorDTO Get(int id) {
            var data = DataAccessFactory.DonorDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Donor, DonorDTO>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<DonorDTO>(data);
            return rt;
        }
        public static DonorDTO Add(DonorDTO donor) {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<DonorDTO, Donor>();
                cfg.CreateMap<Donor, DonorDTO>();    
            });
            var mapper = new Mapper(config);
            var dbdonor = mapper.Map<Donor>(donor);
            var rt = DataAccessFactory.DonorDataAccess().Add(dbdonor);
            if (rt != null) {
                return mapper.Map<DonorDTO>(rt);
            }
            return null;    
        }
    }
}
