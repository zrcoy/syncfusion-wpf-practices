using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using log4net;

namespace syncfusion_wpf_app_datagrid
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhjVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jS3xRd0ZmWXxXc31QTg==;Mgo+DSMBPh8sVXJ0S0J+XE9HflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TdEdhWHxbcHdcQmFaWQ==;ORg4AjUWIQA/Gnt2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkdhW35ddXRWT2RfWEw=;MTE4MjE0NkAzMjMwMmUzNDJlMzBuMnJKMHZFTlpPdHpmWmtEQ3k1VjZ1Y0RWZVFoZlViY3dpUEVsY08xaWprPQ==;MTE4MjE0N0AzMjMwMmUzNDJlMzBrWDVxeXd4clFtUEhpRDBCRzVuQWp5YXNyeWRwNGhydll2ZXRDTHNSQW9nPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFxKVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUVhW31fc3FVRWlZU0V+;MTE4MjE0OUAzMjMwMmUzNDJlMzBrOEZ1QmRuMnBObmlNaGI4bGVYNmNuc3AxOUVFckF4Wm40T0lYbERnZ2gwPQ==;MTE4MjE1MEAzMjMwMmUzNDJlMzBVSTRwTVk5QTNzNmtRNnZsc09LV1NJOVJtV2VPM3EvZVhWWDRaeTlYYmY0PQ==;Mgo+DSMBMAY9C3t2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkdhW35ddXRWT2ZYU0E=;MTE4MjE1MkAzMjMwMmUzNDJlMzBIN2IwaGhuemJuY2xMQWMxUmFlbE5Sbm9CSE5KWFhyVzZpU010L1BlbXZNPQ==;MTE4MjE1M0AzMjMwMmUzNDJlMzBCQVkzaUxHYlhlWTJKZ29mVVFyQ1k2UW9Na0tnMWs3SUVxV0ErVE1ad1Y0PQ==;MTE4MjE1NEAzMjMwMmUzNDJlMzBrOEZ1QmRuMnBObmlNaGI4bGVYNmNuc3AxOUVFckF4Wm40T0lYbERnZ2gwPQ==");
        }

        private static readonly ILog log = LogManager.GetLogger(typeof(App));
        protected override void OnStartup(StartupEventArgs e)
        {
            log4net.Config.XmlConfigurator.Configure();
            log.Info("        =============  Started Logging  =============        ");
            base.OnStartup(e);
        }
    }
}
