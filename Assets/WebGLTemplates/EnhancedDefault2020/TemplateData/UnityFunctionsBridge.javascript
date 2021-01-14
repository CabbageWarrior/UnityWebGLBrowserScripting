var UnityFunctions = {
	Start: function() {
		window.gameInstance.SendMessage('UnityFunctionsGameObject', 'MyFunction');
		window.gameInstance.SendMessage('UnityFunctionsGameObject', 'MyIntFunction', 5);

		window.gameInstance.SendMessage('UnityFunctionsGameObject', 'MyStringFunction', 'MyString');
	}
};
