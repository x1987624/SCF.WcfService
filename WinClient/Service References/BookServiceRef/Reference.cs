﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinClient.BookServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookServiceRef.IBookService")]
    public interface IBookService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBook", ReplyAction="http://tempuri.org/IBookService/GetBookResponse")]
        string GetBook(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBook", ReplyAction="http://tempuri.org/IBookService/GetBookResponse")]
        System.Threading.Tasks.Task<string> GetBookAsync(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBook", ReplyAction="http://tempuri.org/IBookService/AddBookResponse")]
        string AddBook(string book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBook", ReplyAction="http://tempuri.org/IBookService/AddBookResponse")]
        System.Threading.Tasks.Task<string> AddBookAsync(string book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/EditBook", ReplyAction="http://tempuri.org/IBookService/EditBookResponse")]
        string EditBook(string book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/EditBook", ReplyAction="http://tempuri.org/IBookService/EditBookResponse")]
        System.Threading.Tasks.Task<string> EditBookAsync(string book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/Search", ReplyAction="http://tempuri.org/IBookService/SearchResponse")]
        string Search(string Category, string searchString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/Search", ReplyAction="http://tempuri.org/IBookService/SearchResponse")]
        System.Threading.Tasks.Task<string> SearchAsync(string Category, string searchString);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookServiceChannel : WinClient.BookServiceRef.IBookService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookServiceClient : System.ServiceModel.ClientBase<WinClient.BookServiceRef.IBookService>, WinClient.BookServiceRef.IBookService {
        
        public BookServiceClient() {
        }
        
        public BookServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetBook(string Id) {
            return base.Channel.GetBook(Id);
        }
        
        public System.Threading.Tasks.Task<string> GetBookAsync(string Id) {
            return base.Channel.GetBookAsync(Id);
        }
        
        public string AddBook(string book) {
            return base.Channel.AddBook(book);
        }
        
        public System.Threading.Tasks.Task<string> AddBookAsync(string book) {
            return base.Channel.AddBookAsync(book);
        }
        
        public string EditBook(string book) {
            return base.Channel.EditBook(book);
        }
        
        public System.Threading.Tasks.Task<string> EditBookAsync(string book) {
            return base.Channel.EditBookAsync(book);
        }
        
        public string Search(string Category, string searchString) {
            return base.Channel.Search(Category, searchString);
        }
        
        public System.Threading.Tasks.Task<string> SearchAsync(string Category, string searchString) {
            return base.Channel.SearchAsync(Category, searchString);
        }
    }
}
