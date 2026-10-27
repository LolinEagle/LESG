using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour{
	[SerializeField] private TMP_Text		headerField;
	[SerializeField] private TMP_Text		conntentField;
	[SerializeField] private LayoutElement	layoutElement;
	[SerializeField] private int			maxCharacter;

	public void SetText(string header, string content = ""){
		headerField.text = header;
		conntentField.text = content;

		int	headerLength = headerField.text.Length;
		int	conntentLength = conntentField.text.Length;

		layoutElement.enabled = (headerLength > maxCharacter || conntentLength > maxCharacter) ? true : false;
	}

	private void Update(){
		Vector2	mousePosition = Input.mousePosition;
		transform.position = mousePosition;
	}
}

