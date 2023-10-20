namespace CustomLib
{
    /// <summary>
    /// 고객 클래스
    /// </summary>
    public class Custom
    {
        /// <summary>
        /// 고객 ID - 가져오기
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// 고객 이름 - 가져오기
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 설명 - 가져오기 및 설정하기
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="id">고객 ID</param>
        /// <param name="name">고객 이름</param>
        /// <param name="description">고객</param>
        public Custom(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
        /// <summary>
        /// ToString 메서드 재정의
        /// </summary>
        /// <returns>고객 이름</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
