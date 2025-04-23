using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;

namespace OrtoPulito
{
    internal class Program
    {
        
        enum Pagina
        {
            GIOCO,
            TUTORIAL,
            MENU,
            NEGOZIO
        }

        static Pagina pagina = Pagina.MENU;

        static string path = "C:\\Users\\Utente\\OneDrive - IIS MARCONI PIERALISI - JESI\\ANNOSCOLASTICO23-24\\informatica\\Orto\\";

        static bool mouseTenutoPremuto = false;


        static void Main(string[] args)
        {
            RenderWindow finestra = new RenderWindow(new VideoMode(1140, 900), "Orto");
            finestra.SetFramerateLimit(60);

            //chiude la finestra con un tasto
            finestra.Closed += (sender, e) => finestra.Close();

            //creo font e scrivo il testo
            Font font = new Font("C:\\Windows\\Fonts\\arial.ttf");

            Texture backgroundTexture = new Texture(path + "Fatt_Sfondo.png");
            Sprite menu_sfondo = new Sprite(backgroundTexture);

            Texture scrittaTitolo = new Texture(path + "TitoloMenu.png");
            Sprite titoloMenu = new Sprite(scrittaTitolo);

            Texture play = new Texture(path + "Play (2).png");
            Sprite tastoPlay = new Sprite(play);
            tastoPlay.Position = new Vector2f(650, 280);

            Texture libro = new Texture(path + "Libro.png");
            Sprite tastoLibro = new Sprite(libro);
            tastoLibro.Position = new Vector2f(680, 380);

            Texture tutorial = new Texture(path + "Pergamena (2).png");
            Sprite pergamena = new Sprite(tutorial);

            Texture exitTutorial = new Texture(path + "X-100x100.png");
            Sprite tastoX = new Sprite(exitTutorial);
            tastoX.Position = new Vector2f(1000, 100);

            Texture scrittura1Tutorial = new Texture(path + "Parte1Tutorial.png");
            Sprite parte1Tutorial = new Sprite(scrittura1Tutorial);
            parte1Tutorial.Position = new Vector2f(150, 200);

            Texture scrittura2Tutorial = new Texture(path + "Parte2Tutorial.png");
            Sprite parte2Tutorial = new Sprite(scrittura2Tutorial);
            parte2Tutorial.Position = new Vector2f(580, 130);

            Texture cartello = new Texture(path + "Bacheca2.png");
            Sprite bacheca = new Sprite(cartello);
            bacheca.Position = new Vector2f(400, 200);

            Texture campo = new Texture(path + "CampoGioco.png");
            Sprite sfondoCampi = new Sprite(campo);
            sfondoCampi.Position = new Vector2f(50, 30);

            Texture iconaShop = new Texture(path + "Shop.png");
            Sprite shop = new Sprite(iconaShop);
            shop.Position = new Vector2f(110, 30);

            Texture dentroNegozio = new Texture(path + "Negozio.png");
            Sprite negozio = new Sprite(dentroNegozio);
            negozio.Position = new Vector2f(100, 50);

            Texture back = new Texture(path + "Indietro.png");
            Sprite tastoIndietro = new Sprite(back);
            tastoIndietro.Position = new Vector2f(100, 50);

            Texture tavola = new Texture(path + "Tavola.png");
            Sprite contatoreLegno = new Sprite(tavola);
            contatoreLegno.Position = new Vector2f(700, 30);

            Texture iconaCoin = new Texture(path + "Moneta.png");
            Sprite moneta = new Sprite(iconaCoin);
            moneta.Position = new Vector2f(670, 50);

            Texture iconaCoin2 = new Texture(path + "Moneta.png");
            Sprite moneta2 = new Sprite(iconaCoin2);
            moneta2.Position = new Vector2f(470, 330);

            Texture tavola2 = new Texture(path + "IMGinventario.png");
            Sprite inventario = new Sprite(tavola2);
            inventario.Position = new Vector2f(60, 670);

            Texture iconaAcqua = new Texture(path + "Acqua.png");
            Sprite acqua = new Sprite(iconaAcqua);
            acqua.Position = new Vector2f(75, 700);

            Texture iconaPala = new Texture(path + "Pala.png");
            Sprite pala = new Sprite(iconaPala);
            pala.Position = new Vector2f(170, 670);

            Texture iconaAratro = new Texture(path + "Aratro.png");
            Sprite aratro = new Sprite(iconaAratro);
            aratro.Position = new Vector2f(265, 680);

            Texture espositore = new Texture(path + "Espositore.png");
            Sprite cartelloNegozio  = new Sprite(espositore);
            cartelloNegozio.Position = new Vector2f(370, 50);

            Texture piu = new Texture(path + "PIU.png");
            Sprite compra = new Sprite(piu);
            compra.Position = new Vector2f(370, 250);

            Texture acqua2 = new Texture(path + "IconaAcqua.png");
            Sprite acquaNegozio = new Sprite(acqua2);
            acquaNegozio.Position = new Vector2f(460, 250);

            int contatore = 10;
            Text testoContatore = new Text(contatore.ToString(), font, 30)
            {
                Position = new Vector2f(410, 330),
                FillColor = Color.Black,
            };

            string su = "/";
            Text testoSu = new Text(su.ToString(), font, 30)
            {
                Position = new Vector2f(450, 330),
                FillColor = Color.Black,
            };

            int maxAcqua = 10;
            Text testoMaxAcqua = new Text(maxAcqua.ToString(), font, 30)
            {
                Position = new Vector2f(420, 330),
                FillColor = Color.Black,
            };

            int costoAcqua = 20;
            Text testoCostoAcqua = new Text(costoAcqua.ToString(), font, 35)
            {
                Position = new Vector2f(410, 330),
                FillColor = Color.Black,
            };

            int monete = 0;
            Text testoMonete = new Text(monete.ToString(), font, 35)
            {
                Position = new Vector2f(775, 50),
                FillColor = Color.White,
            };

            while (finestra.IsOpen)
            {
                finestra.DispatchEvents();
                finestra.Clear();

                if (Mouse.IsButtonPressed(Mouse.Button.Left))
                {
                    Vector2i mouseposition = Mouse.GetPosition(finestra);
                    Vector2f mouseworldposition = finestra.MapPixelToCoords(mouseposition);

                    if (tastoX.GetGlobalBounds().Contains(mouseworldposition.X, mouseworldposition.Y))
                    {
                        pagina = Pagina.MENU;
                    }
                    else if (tastoPlay.GetGlobalBounds().Contains(mouseworldposition.X, mouseworldposition.Y) || tastoIndietro.GetGlobalBounds().Contains(mouseworldposition.X, mouseworldposition.Y))
                    {
                        pagina = Pagina.GIOCO;
                    }
                    else if (tastoLibro.GetGlobalBounds().Contains(mouseworldposition.X, mouseworldposition.Y))
                    {
                        pagina = Pagina.TUTORIAL;
                    }
                    else if (shop.GetGlobalBounds().Contains(mouseworldposition.X, mouseworldposition.Y))
                    {
                        pagina = Pagina.NEGOZIO;
                    }
                    else if(compra.GetGlobalBounds().Contains(mouseworldposition.X, mouseworldposition.Y))
                    {
                        if (!mouseTenutoPremuto)
                        {
                            monete = monete - 20;
                            testoMonete.DisplayedString = contatore.ToString();
                            mouseTenutoPremuto = true;
                        }
                        else
                            mouseTenutoPremuto = false;
                    }
                }
                else
                {
                    mouseTenutoPremuto = false;
                }


                switch (pagina)
                {
                    case Pagina.MENU:
                        finestra.Draw(menu_sfondo);
                        finestra.Draw(titoloMenu);
                        finestra.Draw(bacheca);
                        finestra.Draw(tastoPlay);
                        finestra.Draw(tastoLibro);
                        break;

                    case Pagina.TUTORIAL:
                        finestra.Draw(pergamena);
                        finestra.Draw(tastoX);
                        finestra.Draw(parte1Tutorial);
                        finestra.Draw(parte2Tutorial);
                        break;

                    case Pagina.GIOCO:
                        finestra.Draw(sfondoCampi);
                        finestra.Draw(shop);
                        finestra.Draw(contatoreLegno);
                        finestra.Draw(moneta);
                        finestra.Draw(inventario);
                        finestra.Draw(acqua);
                        finestra.Draw(pala);
                        finestra.Draw(aratro);
                        finestra.Draw(testoMonete);
                        break;

                    case Pagina.NEGOZIO:
                        finestra.Draw(negozio);
                        finestra.Draw(tastoIndietro);
                        finestra.Draw(cartelloNegozio);
                        finestra.Draw(acquaNegozio);
                        finestra.Draw(compra);
                        finestra.Draw(testoCostoAcqua);
                        finestra.Draw(moneta2);
                        finestra.Draw(moneta);
                        finestra.Draw(contatoreLegno);
                        finestra.Draw(testoMonete);
                        break;
                }

                finestra.Display();
            }
        }
    }
}
    

