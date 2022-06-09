using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace pryCarpetaCiudadana.Notificar.Services
{
    public class srvFirebaseConnection
    {

        //const clientCredentials = {
        //  apiKey: 'AIzaSyCmALp1gwQIKc0_etKZJDHx4M1sb7p8JFw',
        //  authDomain: 'carpet-artisan.firebaseapp.com',
        //  projectId: 'carpet-artisan',
        //  storageBucket: 'carpet-artisan.appspot.com',
        //  messagingSenderId: '690929111544',
        //  appId: '1:690929111544:web:8da8fd0fe510584242860d',
        //  measurementId: 'G-6Q45VL89F5',
        //};



        string AuthSecret;
        string BasePath;
        public srvFirebaseConnection(string AuthSecret, string BasePath)
        {
            this.AuthSecret = AuthSecret;
            this.BasePath = BasePath;
        }

        public void fncConnection()
        {
            // Conexión con FireBase
            IFirebaseConfig firebaseConfig = new FirebaseConfig()
            {
                AuthSecret = this.AuthSecret,
                BasePath = this.BasePath
            };

            IFirebaseClient firebaseClient;

            try
            {
                firebaseClient = new FirebaseClient(firebaseConfig);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
