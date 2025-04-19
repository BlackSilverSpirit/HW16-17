using UnityEngine;

public class Hero : Character
{
    private const string _horizontalAxisName = "Horizontal";
    private const string _verticalAxisName = "Vertical";

    protected override void ProcessMovement()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw(_horizontalAxisName), 0, Input.GetAxisRaw(_verticalAxisName));

        Move(input);
    }
}