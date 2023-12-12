using Godot;
using System;

public partial class AlphaTest : Node2D
{
	private Sprite2D _sprite;
	private HSlider _slider;

	public override void _Ready()
	{
		_sprite = GetNode<Sprite2D>("Icon");
        _slider = GetNode<HSlider>("HSlider");

        _slider.ValueChanged += Slider_ValueChanged;
    }

    private void Slider_ValueChanged(double value)
    {
        (_sprite.Material as ShaderMaterial).SetShaderParameter("AlphaParameter", value);
    }
}
