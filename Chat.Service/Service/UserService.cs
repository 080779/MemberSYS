using Chat.IService.Interface;
using Chat.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.DTO.DTO;

namespace Chat.Service.Service
{
    public class UserService : IUserService
    {
        #region MyRegion
        public List<UserDTO> GetLayerModelList(int lay1, int lay2)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                CommonService<UserEntity> cs = new CommonService<UserEntity>(dbc);
                return cs.GetAll().Where(p => p.Layer > lay1 && p.Layer < lay2).ToList().Select(r =>
                new UserDTO
                {
                    UserCode = r.UserCode,
                    AddGLTime = r.AddGLTime,
                    AgentsID = r.AgentsID,
                    Address = r.Address,
                    AllBonusAccount = r.AllBonusAccount,
                    BankAccount = r.BankAccount,
                    BankAccountUser = r.BankAccountUser,
                    BankBranch = r.BankBranch,
                    BankInCity = r.BankInCity,
                    BankInProvince = r.BankInProvince,
                    BankName = r.BankName,
                    BillCount = r.BillCount,
                    BonusAccount = r.BonusAccount,
                    CenterBalance = r.CenterBalance,
                    CenterNewScore = r.CenterNewScore,
                    CenterScore = r.CenterScore,
                    CenterZT = r.CenterZT,
                    CreateTime = r.CreateTime,
                    Emoney = r.Emoney,
                    Gender = r.Gender,
                    GLmoney = r.GLmoney,
                    ID = r.ID,
                    IdenCode = r.IdenCode,
                    IsAgent = r.IsAgent,
                    IsLock = r.IsLock,
                    IsOpend = r.IsOpend,
                    Layer = r.Layer,
                    LeftBalance = r.LeftBalance,
                    LeftNewScore = r.LeftNewScore,
                    LeftScore = r.LeftScore,
                    LeftZT = r.LeftZT,
                    LevelID = r.LevelID,
                    Location = r.Location,
                    NiceName = r.NiceName,
                    OpenTime = r.OpenTime,
                    ParentCode = r.ParentCode,
                    ParentID = r.ParentID,
                    Password = r.Password,
                    PhoneNum = r.PhoneNum,
                    QQnumer = r.QQnumer,
                    RecommendCode = r.RecommendCode,
                    RecommendGenera = r.RecommendGenera,
                    RecommendID = r.RecommendID,
                    RecommendPath = r.RecommendPath,
                    RegMoney = r.RegMoney,
                    RegTime = r.RegTime,
                    RightBalance = r.RightBalance,
                    RightNewScore = r.RightNewScore,
                    RightScore = r.RightScore,
                    RightZT = r.RightZT,
                    SafetyCodeAnswer = r.SafetyCodeAnswer,
                    SafetyCodeQuestion = r.SafetyCodeQuestion,
                    SecondPassword = r.SecondPassword,
                    ShopAccount = r.ShopAccount,
                    StockAccount = r.StockAccount,
                    StockMoney = r.StockMoney,
                    ThreePassword = r.ThreePassword,
                    TrueName = r.TrueName,
                    User001 = r.User001,
                    User002 = r.User002,
                    User003 = r.User003,
                    User004 = r.User004,
                    User005 = r.User005,
                    User006 = r.User006,
                    User007 = r.User007,
                    User008 = r.User008,
                    User009 = r.User009,
                    User010 = r.User010,
                    User011 = r.User012,
                    User013 = r.User013,
                    User014 = r.User014,
                    User015 = r.User015,
                    User016 = r.User016,
                    User017 = r.User017,
                    User018 = r.User018,
                    User012 = r.User012,
                    UserPath = r.UserPath
                }).ToList();
            }
        }
        #endregion
        public List<UserDTO> GetRecommendModelList(long RecommendID)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                CommonService<UserEntity> cs = new CommonService<UserEntity>(dbc);
                return cs.GetAll().Where(p => p.RecommendID == RecommendID).ToList().Select(r =>
                new UserDTO
                {
                    UserCode = r.UserCode,
                    AddGLTime = r.AddGLTime,
                    AgentsID = r.AgentsID,
                    Address = r.Address,
                    AllBonusAccount = r.AllBonusAccount,
                    BankAccount = r.BankAccount,
                    BankAccountUser = r.BankAccountUser,
                    BankBranch = r.BankBranch,
                    BankInCity = r.BankInCity,
                    BankInProvince = r.BankInProvince,
                    BankName = r.BankName,
                    BillCount = r.BillCount,
                    BonusAccount = r.BonusAccount,
                    CenterBalance = r.CenterBalance,
                    CenterNewScore = r.CenterNewScore,
                    CenterScore = r.CenterScore,
                    CenterZT = r.CenterZT,
                    CreateTime = r.CreateTime,
                    Emoney = r.Emoney,
                    Gender = r.Gender,
                    GLmoney = r.GLmoney,
                    ID = r.ID,
                    IdenCode = r.IdenCode,
                    IsAgent = r.IsAgent,
                    IsLock = r.IsLock,
                    IsOpend = r.IsOpend,
                    Layer = r.Layer,
                    LeftBalance = r.LeftBalance,
                    LeftNewScore = r.LeftNewScore,
                    LeftScore = r.LeftScore,
                    LeftZT = r.LeftZT,
                    LevelID = r.LevelID,
                    Location = r.Location,
                    NiceName = r.NiceName,
                    OpenTime = r.OpenTime,
                    ParentCode = r.ParentCode,
                    ParentID = r.ParentID,
                    Password = r.Password,
                    PhoneNum = r.PhoneNum,
                    QQnumer = r.QQnumer,
                    RecommendCode = r.RecommendCode,
                    RecommendGenera = r.RecommendGenera,
                    RecommendID = r.RecommendID,
                    RecommendPath = r.RecommendPath,
                    RegMoney = r.RegMoney,
                    RegTime = r.RegTime,
                    RightBalance = r.RightBalance,
                    RightNewScore = r.RightNewScore,
                    RightScore = r.RightScore,
                    RightZT = r.RightZT,
                    SafetyCodeAnswer = r.SafetyCodeAnswer,
                    SafetyCodeQuestion = r.SafetyCodeQuestion,
                    SecondPassword = r.SecondPassword,
                    ShopAccount = r.ShopAccount,
                    StockAccount = r.StockAccount,
                    StockMoney = r.StockMoney,
                    ThreePassword = r.ThreePassword,
                    TrueName = r.TrueName,
                    User001 = r.User001,
                    User002 = r.User002,
                    User003 = r.User003,
                    User004 = r.User004,
                    User005 = r.User005,
                    User006 = r.User006,
                    User007 = r.User007,
                    User008 = r.User008,
                    User009 = r.User009,
                    User010 = r.User010,
                    User011 = r.User012,
                    User013 = r.User013,
                    User014 = r.User014,
                    User015 = r.User015,
                    User016 = r.User016,
                    User017 = r.User017,
                    User018 = r.User018,
                    User012 = r.User012,
                    UserPath = r.UserPath
                }).ToList();
            }
        }
        /// <summary>
        /// 根据ID查询用户
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public UserDTO GetModel(long Id)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                CommonService<UserEntity> cs = new CommonService<UserEntity>(dbc);
                UserEntity r = cs.GetById(Id);
                if (r != null)
                {
                    return new UserDTO
                    {
                        UserCode = r.UserCode,
                        AddGLTime = r.AddGLTime,
                        AgentsID = r.AgentsID,
                        Address = r.Address,
                        AllBonusAccount = r.AllBonusAccount,
                        BankAccount = r.BankAccount,
                        BankAccountUser = r.BankAccountUser,
                        BankBranch = r.BankBranch,
                        BankInCity = r.BankInCity,
                        BankInProvince = r.BankInProvince,
                        BankName = r.BankName,
                        BillCount = r.BillCount,
                        BonusAccount = r.BonusAccount,
                        CenterBalance = r.CenterBalance,
                        CenterNewScore = r.CenterNewScore,
                        CenterScore = r.CenterScore,
                        CenterZT = r.CenterZT,
                        CreateTime = r.CreateTime,
                        Emoney = r.Emoney,
                        Gender = r.Gender,
                        GLmoney = r.GLmoney,
                        ID = r.ID,
                        IdenCode = r.IdenCode,
                        IsAgent = r.IsAgent,
                        IsLock = r.IsLock,
                        IsOpend = r.IsOpend,
                        Layer = r.Layer,
                        LeftBalance = r.LeftBalance,
                        LeftNewScore = r.LeftNewScore,
                        LeftScore = r.LeftScore,
                        LeftZT = r.LeftZT,
                        LevelID = r.LevelID,
                        Location = r.Location,
                        NiceName = r.NiceName,
                        OpenTime = r.OpenTime,
                        ParentCode = r.ParentCode,
                        ParentID = r.ParentID,
                        Password = r.Password,
                        PhoneNum = r.PhoneNum,
                        QQnumer = r.QQnumer,
                        RecommendCode = r.RecommendCode,
                        RecommendGenera = r.RecommendGenera,
                        RecommendID = r.RecommendID,
                        RecommendPath = r.RecommendPath,
                        RegMoney = r.RegMoney,
                        RegTime = r.RegTime,
                        RightBalance = r.RightBalance,
                        RightNewScore = r.RightNewScore,
                        RightScore = r.RightScore,
                        RightZT = r.RightZT,
                        SafetyCodeAnswer = r.SafetyCodeAnswer,
                        SafetyCodeQuestion = r.SafetyCodeQuestion,
                        SecondPassword = r.SecondPassword,
                        ShopAccount = r.ShopAccount,
                        StockAccount = r.StockAccount,
                        StockMoney = r.StockMoney,
                        ThreePassword = r.ThreePassword,
                        TrueName = r.TrueName,
                        User001 = r.User001,
                        User002 = r.User002,
                        User003 = r.User003,
                        User004 = r.User004,
                        User005 = r.User005,
                        User006 = r.User006,
                        User007 = r.User007,
                        User008 = r.User008,
                        User009 = r.User009,
                        User010 = r.User010,
                        User011 = r.User012,
                        User013 = r.User013,
                        User014 = r.User014,
                        User015 = r.User015,
                        User016 = r.User016,
                        User017 = r.User017,
                        User018 = r.User018,
                        User012 = r.User012,
                        UserPath = r.UserPath
                    };
                }
                else
                {
                    return null;
                }
            }
        }
        public bool UpdatePath(UserDTO model)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                var usermodel = dbc.User.Where(p => p.ID == model.ID).First();
                usermodel.UserPath = model.UserPath;
                usermodel.RecommendPath = model.RecommendPath;
                int count = dbc.SaveChanges();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        /// <summary>
        /// 根据ID查询用户
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public UserDTO GetModelCode(string code)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                CommonService<UserEntity> cs = new CommonService<UserEntity>(dbc);
                UserEntity r = cs.GetAll().SingleOrDefault(p => p.UserCode == code);
                if (r != null)
                {
                    return new UserDTO
                    {
                        UserCode = r.UserCode,
                        AddGLTime = r.AddGLTime,
                        AgentsID = r.AgentsID,
                        Address = r.Address,
                        AllBonusAccount = r.AllBonusAccount,
                        BankAccount = r.BankAccount,
                        BankAccountUser = r.BankAccountUser,
                        BankBranch = r.BankBranch,
                        BankInCity = r.BankInCity,
                        BankInProvince = r.BankInProvince,
                        BankName = r.BankName,
                        BillCount = r.BillCount,
                        BonusAccount = r.BonusAccount,
                        CenterBalance = r.CenterBalance,
                        CenterNewScore = r.CenterNewScore,
                        CenterScore = r.CenterScore,
                        CenterZT = r.CenterZT,
                        CreateTime = r.CreateTime,
                        Emoney = r.Emoney,
                        Gender = r.Gender,
                        GLmoney = r.GLmoney,
                        ID = r.ID,
                        IdenCode = r.IdenCode,
                        IsAgent = r.IsAgent,
                        IsLock = r.IsLock,
                        IsOpend = r.IsOpend,
                        Layer = r.Layer,
                        LeftBalance = r.LeftBalance,
                        LeftNewScore = r.LeftNewScore,
                        LeftScore = r.LeftScore,
                        LeftZT = r.LeftZT,
                        LevelID = r.LevelID,
                        Location = r.Location,
                        NiceName = r.NiceName,
                        OpenTime = r.OpenTime,
                        ParentCode = r.ParentCode,
                        ParentID = r.ParentID,
                        Password = r.Password,
                        PhoneNum = r.PhoneNum,
                        QQnumer = r.QQnumer,
                        RecommendCode = r.RecommendCode,
                        RecommendGenera = r.RecommendGenera,
                        RecommendID = r.RecommendID,
                        RecommendPath = r.RecommendPath,
                        RegMoney = r.RegMoney,
                        RegTime = r.RegTime,
                        RightBalance = r.RightBalance,
                        RightNewScore = r.RightNewScore,
                        RightScore = r.RightScore,
                        RightZT = r.RightZT,
                        SafetyCodeAnswer = r.SafetyCodeAnswer,
                        SafetyCodeQuestion = r.SafetyCodeQuestion,
                        SecondPassword = r.SecondPassword,
                        ShopAccount = r.ShopAccount,
                        StockAccount = r.StockAccount,
                        StockMoney = r.StockMoney,
                        ThreePassword = r.ThreePassword,
                        TrueName = r.TrueName,
                        User001 = r.User001,
                        User002 = r.User002,
                        User003 = r.User003,
                        User004 = r.User004,
                        User005 = r.User005,
                        User006 = r.User006,
                        User007 = r.User007,
                        User008 = r.User008,
                        User009 = r.User009,
                        User010 = r.User010,
                        User011 = r.User012,
                        User013 = r.User013,
                        User014 = r.User014,
                        User015 = r.User015,
                        User016 = r.User016,
                        User017 = r.User017,
                        User018 = r.User018,
                        User012 = r.User012,
                        UserPath = r.UserPath
                    };
                }
                else
                {
                    return null;
                }
            }
        }
        public long Add(UserDTO model)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                CommonService<UserEntity> cs = new CommonService<UserEntity>(dbc);
                UserEntity usermodel = new UserEntity();
                usermodel.UserCode = model.UserCode;
                usermodel.AddGLTime = model.AddGLTime;
                usermodel.AgentsID = model.AgentsID;
                usermodel.Address = model.Address;
                usermodel.AllBonusAccount = model.AllBonusAccount;
                usermodel.BankAccount = model.BankAccount;
                usermodel.BankAccountUser = model.BankAccountUser;
                usermodel.BankBranch = model.BankBranch;
                usermodel.BankInCity = model.BankInCity;
                usermodel.BankInProvince = model.BankInProvince;
                usermodel.BankName = model.BankName;
                usermodel.BillCount = model.BillCount;
                usermodel.BonusAccount = model.BonusAccount;
                usermodel.CenterBalance = model.CenterBalance;
                usermodel.CenterNewScore = model.CenterNewScore;
                usermodel.CenterScore = model.CenterScore;
                usermodel.CenterZT = model.CenterZT;
                usermodel.CreateTime = model.CreateTime;
                usermodel.Emoney = model.Emoney;
                usermodel.Gender = model.Gender;
                usermodel.GLmoney = model.GLmoney;
                //usermodel.ID = model.ID;
                usermodel.IdenCode = model.IdenCode;
                usermodel.IsAgent = model.IsAgent;
                usermodel.IsLock = model.IsLock;
                usermodel.IsOpend = model.IsOpend;
                usermodel.Layer = model.Layer;
                usermodel.LeftBalance = model.LeftBalance;
                usermodel.LeftNewScore = model.LeftNewScore;
                usermodel.LeftScore = model.LeftScore;
                usermodel.LeftZT = model.LeftZT;
                usermodel.LevelID = model.LevelID;
                usermodel.Location = model.Location;
                usermodel.NiceName = model.NiceName;
                usermodel.OpenTime = model.OpenTime;
                usermodel.ParentCode = model.ParentCode;
                usermodel.ParentID = model.ParentID;
                usermodel.Password = model.Password;
                usermodel.PhoneNum = model.PhoneNum;
                usermodel.QQnumer = model.QQnumer;
                usermodel.RecommendCode = model.RecommendCode;
                usermodel.RecommendGenera = model.RecommendGenera;
                usermodel.RecommendID = model.RecommendID;
                usermodel.RecommendPath = model.RecommendPath;
                usermodel.RegMoney = model.RegMoney;
                usermodel.RegTime = model.RegTime;
                usermodel.RightBalance = model.RightBalance;
                usermodel.RightNewScore = model.RightNewScore;
                usermodel.RightScore = model.RightScore;
                usermodel.RightZT = model.RightZT;
                usermodel.SafetyCodeAnswer = model.SafetyCodeAnswer;
                usermodel.SafetyCodeQuestion = model.SafetyCodeQuestion;
                usermodel.SecondPassword = model.SecondPassword;
                usermodel.ShopAccount = model.ShopAccount;
                usermodel.StockAccount = model.StockAccount;
                usermodel.StockMoney = model.StockMoney;
                usermodel.ThreePassword = model.ThreePassword;
                usermodel.TrueName = model.TrueName;
                usermodel.User001 = model.User001;
                usermodel.User002 = model.User002;
                usermodel.User003 = model.User003;
                usermodel.User004 = model.User004;
                usermodel.User005 = model.User005;
                usermodel.User006 = model.User006;
                usermodel.User007 = model.User007;
                usermodel.User008 = model.User008;
                usermodel.User009 = model.User009;
                usermodel.User010 = model.User010;
                usermodel.User011 = model.User012;
                usermodel.User013 = model.User013;
                usermodel.User014 = model.User014;
                usermodel.User015 = model.User015;
                usermodel.User016 = model.User016;
                usermodel.User017 = model.User017;
                usermodel.User018 = model.User018;
                usermodel.User012 = model.User012;
                usermodel.UserPath = model.UserPath;
                dbc.User.Add(usermodel);
                dbc.SaveChanges();
                return usermodel.ID;

            }
        }
        public UserDTO GetLocationModel(int Id)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                CommonService<UserEntity> cs = new CommonService<UserEntity>(dbc);
                UserEntity r = cs.GetAll().Where(p => p.IsOpend == 2 && p.Location == 1 && p.ParentID == Id).SingleOrDefault();
                if (r != null)
                {
                    return new UserDTO
                    {
                        UserCode = r.UserCode,
                        AddGLTime = r.AddGLTime,
                        AgentsID = r.AgentsID,
                        Address = r.Address,
                        AllBonusAccount = r.AllBonusAccount,
                        BankAccount = r.BankAccount,
                        BankAccountUser = r.BankAccountUser,
                        BankBranch = r.BankBranch,
                        BankInCity = r.BankInCity,
                        BankInProvince = r.BankInProvince,
                        BankName = r.BankName,
                        BillCount = r.BillCount,
                        BonusAccount = r.BonusAccount,
                        CenterBalance = r.CenterBalance,
                        CenterNewScore = r.CenterNewScore,
                        CenterScore = r.CenterScore,
                        CenterZT = r.CenterZT,
                        CreateTime = r.CreateTime,
                        Emoney = r.Emoney,
                        Gender = r.Gender,
                        GLmoney = r.GLmoney,
                        ID = r.ID,
                        IdenCode = r.IdenCode,
                        IsAgent = r.IsAgent,
                        IsLock = r.IsLock,
                        IsOpend = r.IsOpend,
                        Layer = r.Layer,
                        LeftBalance = r.LeftBalance,
                        LeftNewScore = r.LeftNewScore,
                        LeftScore = r.LeftScore,
                        LeftZT = r.LeftZT,
                        LevelID = r.LevelID,
                        Location = r.Location,
                        NiceName = r.NiceName,
                        OpenTime = r.OpenTime,
                        ParentCode = r.ParentCode,
                        ParentID = r.ParentID,
                        Password = r.Password,
                        PhoneNum = r.PhoneNum,
                        QQnumer = r.QQnumer,
                        RecommendCode = r.RecommendCode,
                        RecommendGenera = r.RecommendGenera,
                        RecommendID = r.RecommendID,
                        RecommendPath = r.RecommendPath,
                        RegMoney = r.RegMoney,
                        RegTime = r.RegTime,
                        RightBalance = r.RightBalance,
                        RightNewScore = r.RightNewScore,
                        RightScore = r.RightScore,
                        RightZT = r.RightZT,
                        SafetyCodeAnswer = r.SafetyCodeAnswer,
                        SafetyCodeQuestion = r.SafetyCodeQuestion,
                        SecondPassword = r.SecondPassword,
                        ShopAccount = r.ShopAccount,
                        StockAccount = r.StockAccount,
                        StockMoney = r.StockMoney,
                        ThreePassword = r.ThreePassword,
                        TrueName = r.TrueName,
                        User001 = r.User001,
                        User002 = r.User002,
                        User003 = r.User003,
                        User004 = r.User004,
                        User005 = r.User005,
                        User006 = r.User006,
                        User007 = r.User007,
                        User008 = r.User008,
                        User009 = r.User009,
                        User010 = r.User010,
                        User011 = r.User012,
                        User013 = r.User013,
                        User014 = r.User014,
                        User015 = r.User015,
                        User016 = r.User016,
                        User017 = r.User017,
                        User018 = r.User018,
                        User012 = r.User012,
                        UserPath = r.UserPath
                    };
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 获取层数
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public int NodeNun(long UserID)
        {
            using (MyDbContext dbcontext = new MyDbContext())
            {
                CommonService<UserEntity> csr = new CommonService<UserEntity>(dbcontext);
                UserEntity model = csr.GetById(UserID);
                if (model != null)
                {
                    return model.Layer;
                }
                else
                {
                    return 0;
                }
            }
        }

        public long CheckLogin(string userCode,string password)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                CommonService<UserEntity> cs = new CommonService<UserEntity>(dbc);
                var user = cs.GetAll().SingleOrDefault(u => u.UserCode == userCode);
                if(user==null)
                {
                    return -1;//用户不存在
                }
                if(user.Password!=password)
                {
                    return -2;//密码错误
                }
                return user.ID;
            }
        }

        #region 收件箱获得代理编号
        /// <summary>
        /// 收件箱获得代理编号
        /// </summary>
        /// <param name="id">代理id</param>
        /// <param name="type">代理类型1：代理2：管理员</param>
        /// <returns></returns>
        public string GetUserCodeForMessage(long id, int type)
        {
            using (MyDbContext dbcontext = new MyDbContext())
            {

                if (type == 1)
                {
                    CommonService<UserEntity> csr = new CommonService<UserEntity>(dbcontext);
                    UserEntity model = csr.GetById(id);
                    if (model == null)
                    {
                        return "";
                    }
                    return model.UserCode;
                }
                else if (type == 2)
                {
                    CommonService<AdminEntity> csr = new CommonService<AdminEntity>(dbcontext);
                    AdminEntity model = csr.GetById(id);
                    if (model == null)
                    {
                        return "";
                    }
                    return model.UserName;
                }
                else
                {
                    return "";
                }
            }
        }
        #endregion
        public bool UpdateLoginInfo(UserDTO model)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                var usermodel = dbc.User.Where(p => p.ID == model.ID).First();
                usermodel.PhoneNum = model.PhoneNum;
                //usermodel.RecommendPath = model.RecommendPath;
                int count = dbc.SaveChanges();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool UpdateLogPwd(UserDTO model)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                var usermodel = dbc.User.Where(p => p.ID == model.ID).First();
                usermodel.Password = model.Password;
                //usermodel.RecommendPath = model.RecommendPath;
                int count = dbc.SaveChanges();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool UpdateScodePwd(UserDTO model)
        {

            using (MyDbContext dbc = new MyDbContext())
            {
                var usermodel = dbc.User.Where(p => p.ID == model.ID).First();
                usermodel.SecondPassword = model.SecondPassword;
                //usermodel.RecommendPath = model.RecommendPath;
                int count = dbc.SaveChanges();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool UpdateBaseInfo(UserDTO model)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                var usermodel = dbc.User.Where(p => p.ID == model.ID).First();
                usermodel.TrueName = model.TrueName;
                usermodel.BankAccount = model.BankAccount;
                usermodel.BankName = model.BankName;
                usermodel.BankBranch = model.BankBranch;
                usermodel.BankAccountUser = model.BankAccountUser;
                usermodel.IdenCode = model.IdenCode;
                //usermodel.RecommendPath = model.RecommendPath;
                int count = dbc.SaveChanges();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
