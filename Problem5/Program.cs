using System;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Builder Pattern and prototype pattern in same time
            AppBuilder builder = new AppBuilder();
            App shutkiapp = builder.SetAppName("ShutkiBajar")
                .SetAppAuth("token")
                .SetAppUrl("www.shutkibajar.com")
                .SetORM("EntityFramework")
                .Cors("shutkibajar.com")
                .Port(8080)
                .Build();
            App shutkiClone = shutkiapp.Clone();

        }
    }

    class App
    {
        public string AppName { get; set; }
        public string AppUrl { get; set; }
        public int Port { get; set; }
        public string ORMPackage{get;set;}
        public string Cors { get; set; }
        public string Auth { get; set; }

        public App Clone()
        {
            return new App
            {
                AppName = this.AppName,
                Auth = this.Auth,
                Cors = this.Cors,
                Port = this.Port,
                AppUrl = this.AppUrl,
                ORMPackage = this.ORMPackage
            };
        }
    }

    class AppBuilder
    {
        private App _app;

        public AppBuilder()
        {
            _app = new App();
        }

        public AppBuilder SetAppName(string AppName)
        {
            this._app.AppName = AppName;
            return this;
        }

        public AppBuilder SetAppUrl(string appurl)
        {
            this._app.AppUrl = appurl;
            return this;
        }
        public AppBuilder Port(int port)
        {
            this._app.Port = port;
            return this;
        }
        public AppBuilder SetORM(string orm)
        {
            this._app.ORMPackage = orm;
            return this;
        }
        public AppBuilder Cors(string cors)
        {
            this._app.Cors = cors;
            return this;
        }
        public AppBuilder SetAppAuth(string auth)
        {
            this._app.Auth = auth;
            return this;
        }

        public App Build()
        {
            return this._app;
        }
    }
}