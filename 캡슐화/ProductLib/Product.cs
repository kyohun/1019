namespace ProductLib
{
    /// <summary>
    /// 상품 클래스
    /// </summary>
    public class Product
    {
        /// <summary>
        /// 상품 ID - 가져오기
        /// </summary>
        public int Id { get;  private set; }
        /// <summary>
        /// 상품 이름 - 가져오기
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 설명 - 가져오기 및 설정하기
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="id">상품 ID</param>
        /// <param name="name">상품 이름</param>
        /// <param name="description">설명</param>
        public Product(int id,string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
        /// <summary>
        /// ToString 메서드 재정의
        /// </summary>
        /// <returns>상품 이름</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
