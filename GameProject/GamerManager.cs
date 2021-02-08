using System;
namespace GameProject

{

    //MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService )
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("doğrulama başarısız. Kayıt başarısız");
            }
            
            
        } 

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi.");

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi.");

        }
    }
}
