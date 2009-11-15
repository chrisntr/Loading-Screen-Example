// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LoadingScreenExample.www.w3schools.com {
    
    
    /// <remarks/>
    [System.Web.Services.WebServiceBinding(Name="TempConvertSoap", Namespace="http://tempuri.org/")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TempConvert : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback FahrenheitToCelsiusOperationCompleted;
        
        private System.Threading.SendOrPostCallback CelsiusToFahrenheitOperationCompleted;
        
        public TempConvert() {
            this.Url = "http://www.w3schools.com/WebServices/TempConvert.asmx";
        }
        
        public TempConvert(string url) {
            this.Url = url;
        }
        
        public event FahrenheitToCelsiusCompletedEventHandler FahrenheitToCelsiusCompleted;
        
        public event CelsiusToFahrenheitCompletedEventHandler CelsiusToFahrenheitCompleted;
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FahrenheitToCelsius", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
        public string FahrenheitToCelsius(string Fahrenheit) {
            object[] results = this.Invoke("FahrenheitToCelsius", new object[] {
                        Fahrenheit});
            return ((string)(results[0]));
        }
        
        public System.IAsyncResult BeginFahrenheitToCelsius(string Fahrenheit, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("FahrenheitToCelsius", new object[] {
                        Fahrenheit}, callback, asyncState);
        }
        
        public string EndFahrenheitToCelsius(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        public void FahrenheitToCelsiusAsync(string Fahrenheit) {
            this.FahrenheitToCelsiusAsync(Fahrenheit, null);
        }
        
        public void FahrenheitToCelsiusAsync(string Fahrenheit, object userState) {
            if ((this.FahrenheitToCelsiusOperationCompleted == null)) {
                this.FahrenheitToCelsiusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFahrenheitToCelsiusCompleted);
            }
            this.InvokeAsync("FahrenheitToCelsius", new object[] {
                        Fahrenheit}, this.FahrenheitToCelsiusOperationCompleted, userState);
        }
        
        private void OnFahrenheitToCelsiusCompleted(object arg) {
            if ((this.FahrenheitToCelsiusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FahrenheitToCelsiusCompleted(this, new FahrenheitToCelsiusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CelsiusToFahrenheit", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
        public string CelsiusToFahrenheit(string Celsius) {
            object[] results = this.Invoke("CelsiusToFahrenheit", new object[] {
                        Celsius});
            return ((string)(results[0]));
        }
        
        public System.IAsyncResult BeginCelsiusToFahrenheit(string Celsius, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("CelsiusToFahrenheit", new object[] {
                        Celsius}, callback, asyncState);
        }
        
        public string EndCelsiusToFahrenheit(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        public void CelsiusToFahrenheitAsync(string Celsius) {
            this.CelsiusToFahrenheitAsync(Celsius, null);
        }
        
        public void CelsiusToFahrenheitAsync(string Celsius, object userState) {
            if ((this.CelsiusToFahrenheitOperationCompleted == null)) {
                this.CelsiusToFahrenheitOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCelsiusToFahrenheitCompleted);
            }
            this.InvokeAsync("CelsiusToFahrenheit", new object[] {
                        Celsius}, this.CelsiusToFahrenheitOperationCompleted, userState);
        }
        
        private void OnCelsiusToFahrenheitCompleted(object arg) {
            if ((this.CelsiusToFahrenheitCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CelsiusToFahrenheitCompleted(this, new CelsiusToFahrenheitCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
    }
    
    public partial class FahrenheitToCelsiusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FahrenheitToCelsiusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    public delegate void FahrenheitToCelsiusCompletedEventHandler(object sender, FahrenheitToCelsiusCompletedEventArgs args);
    
    public partial class CelsiusToFahrenheitCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CelsiusToFahrenheitCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    public delegate void CelsiusToFahrenheitCompletedEventHandler(object sender, CelsiusToFahrenheitCompletedEventArgs args);
}
