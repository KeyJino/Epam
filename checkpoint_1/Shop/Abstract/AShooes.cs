namespace Epam.Shop.Abstract
{
    public abstract class AShooes
    {
        private int _size;
        private int _price;
        private int _materialId;

        public AShooes(int _size, int _price, int _materialId)
        {
            this._price = _price;
            this._size = _size;
            this._materialId = _materialId;
        }

        public int getSize()
        {
            return _size;
        }

        public int getPrice()
        {
            return _price;
        }

        public int getMaterialID()
        {
            return _materialId;
        }


    }
}
