using System;
using System.Windows.Input;
using FomeLine.Models;
using FomeLine.Services;
using Plugin.Media;
using Xamarin.Forms;

namespace FomeLine.ViewModels
{
    public class ProdutoVm : BaseVm
    {
        private const string DefaultImage = "camera.png";

        private int _produtoId;
        public int ProdutoId
        {
            get { return _produtoId; }
            set
            {
                _produtoId = value;
                Notify(nameof(ProdutoId));
            }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                Notify(nameof(Nome));
            }
        }

        private string _imagem;
        public string Imagem
        {
            get { return _imagem; }
            set
            {
                _imagem = value;
                Notify(nameof(Imagem));
            }
        }

        private decimal _valor;
        public decimal Valor
        {
            get
            {
                return _valor;
            }
            set
            {
                _valor = value;
                Notify(nameof(Valor));
            }
        }

        private ImageSource _imageSource;
        public ImageSource ImageSource
        {
            get
            {
                return _imageSource;
            }
            set
            {
                _imageSource = value;
                Notify(nameof(ImageSource));
            }
        }

        public ICommand ListaPedidosCommand { get; set; }
        public ICommand NovoProdutoCommand { get; set; }
        public ICommand TirarFotoCommand { get; set; }
        public ICommand EscolherFotoCommand { get; set; }
        public ICommand GravarCommand { get; set; }

        public ProdutoVm()
        {
            _imageSource = DefaultImage;
            ListaPedidosCommand = new Command(GoToListarPedidos);
            NovoProdutoCommand = new Command(GoToNovoProduto);
            TirarFotoCommand = new Command(TirarFoto);
            EscolherFotoCommand = new Command(EscolherFoto);
            GravarCommand = new Command(Gravar);
        }

        public async void Gravar()
        {
            try
            {
                var product = new Produto();
                product.SetInformation(Nome, Imagem, Valor);

                var service = new ProdutoService();
                service.Insert(product);

                await NavigationService.NavigateToProdutos();
            }
            catch (Exception error)
            {
                await MessageService.ShowAsync(error.Message);
            }
        }

        public async void GoToListarPedidos()
        {
            await NavigationService.NavigateToPedidos();
        }

        public async void GoToNovoProduto()
        {
            await NavigationService.NavigateToAddProduto();
        }
        
        public async void EscolherFoto()
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await MessageService.ShowAsync("Erro", "Sem permissão para acessar suas fotos");
                return;
            }
            var file = await CrossMedia.Current.PickPhotoAsync();

            if (file == null) return;

            Imagem = file.Path;
            ImageSource = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }

        public async void TirarFoto()
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await MessageService.ShowAsync("Erro", "Nenhuma câmera disponível");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "FomeLine",
                Name = string.Format("FomeLine{0}.jpg", DateTime.Now)
            });

            if (file == null) return;

            await MessageService.ShowAsync("Localização do arquivo", file.Path);

            ImageSource = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }
    }
}