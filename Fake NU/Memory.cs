using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalData;

namespace Fake_NU
{
    public class Memory
    {
        private static string localCachePath = FileSystem.Current.CacheDirectory;
        private static string localFilePath = Path.Combine(localCachePath, "data.bin");
        private static DataFile _DataFile;// = new DataFile(localFilePath, "A-32-CHARACTER-PASSWORD-!@#$%\u00a8&*", "16CHARACTERPASSW", "optional_prefix_");

        public static double maxDebit = 300;
        public static double maxCredit = 1300.50;


        public static void start_datafile()
        {
            if (_DataFile == null)
            {
                _DataFile = new DataFile(localFilePath,"PrimeiraSenhaDoArquivo", "SegundaSenha", "optional_prefix_");
            }
        }

        public static double debit
        {
            
            get
            {
                start_datafile();
                return _DataFile.LoadCfg<double>("debit", 15.53);
            }
            set
            {
                start_datafile();
                if (value > maxDebit)
                {
                    _DataFile.SaveCfg<double>("debit", maxDebit);
                }
                else
                {
                    _DataFile.SaveCfg<double>("debit", value);
                }
            }
        }
        
        public static double credit
        {
            get
            {
                start_datafile();
                return _DataFile.LoadCfg<double>("credit", 1500.53);
            }
            set
            {
                start_datafile();
                if (value > maxCredit)
                {
                    _DataFile.SaveCfg<double>("credit", maxCredit);
                }
                else
                {
                    _DataFile.SaveCfg<double>("credit", value);
                }
            }
        }
        public static double fatura
        {
            get
            {
                start_datafile();
                return _DataFile.LoadCfg<double>("fatura", 800.10);
            }
            set
            {
                start_datafile();
                if (value > (maxCredit + 1000))
                {
                    _DataFile.SaveCfg<double>("fatura", maxDebit +1000);
                }
                else
                {
                    _DataFile.SaveCfg<double>("fatura", value);
                }
            }
        }


    }
}
