namespace AllTests
{
    [TestFixture]
    class StackTests
    {
        private MyStack<int>? _stack;

        [SetUp]
        public void SetUp(){
            _stack = new MyStack<int>();
        }


        // Count operations
        [Test]
        public void Count_WhenStackIsEmpty_ReturnsZero(){
            Assert.That(_stack!.Count == 0);
        }

        [Test]
        public void Count_WhenStackContainsOneItem_ReturnsOne(){
            _stack!.Push(1);
            Assert.That(_stack!.Count == 1);
        }

        // Push operations
        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public void Push_WhenStackIsEmpty_PushesItemOntoStack(int item){
            _stack!.Push(item);

            Assert.That(_stack.Count == 1);
            Assert.That(_stack.Peek() == item);
        }


        [Test]
        [TestCase(1, 2)]
        [TestCase(2, 5, 8, 4)]
        public void Push_WhenStackIsNotEmpty_PushesItemOntoStack(params int[] items){

            int lastElement = 0;
            for(int i = 0;i<items.Length;i++){
                if(i == items.Length - 1) lastElement = items[i];
                _stack!.Push(items[i]);    
            }

            Assert.That(_stack!.Count == items.Length);
            Assert.That(_stack!.Peek() == lastElement);
        }


        // Pop operations
        [Test]
        public void Pop_WhenStackIsEmpty_ThrowsInvalidOperationException(){
            Assert.Throws<InvalidOperationException>(() => _stack!.Pop());
        }


        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public void Pop_WhenStackIsNotEmpty_ReturnsPushedItemAndPopsIt(int item){
            
            _stack!.Push(item);
            int oldCount = _stack.Count;

            var top = _stack.Pop();
            int newCount = _stack.Count;


            Assert.That(newCount, Is.EqualTo(oldCount - 1));
            Assert.That(top, Is.EqualTo(item));
        }


        // Peek operations
        [Test]
        public void Peek_WhenStackIsEmpty_ThrowsInvalidOperationException(){
            Assert.Throws<InvalidOperationException>(() => _stack!.Peek());
        }


        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public void Peek_WhenStackIsNotEmpty_ReturnsPushedItem(int item){
            
            _stack!.Push(item);
            int oldCount = _stack.Count;

            var top = _stack.Peek();
            int newCount = _stack.Count;

            Assert.That(newCount, Is.EqualTo(oldCount));
            Assert.That(top, Is.EqualTo(item));
        }
    }
}