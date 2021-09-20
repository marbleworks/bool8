How to use:

var b8 = new bool8();

b8.Set(3, true);

b8.Debug(); // 1000

b8.Set(5, true);

b8.Debug(); // 101000

Debug.log(b8.Get(5)); // True

b8.Toggle(6);

b8.Debug(); // 1101000

b8.ToggleAll();

b8.Debug(); // 10010111
