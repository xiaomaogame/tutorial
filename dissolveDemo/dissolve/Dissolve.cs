using Godot;
using System;

public partial class Dissolve : Node2D
{
    Sprite2D sprite2D;
    HSlider slider;

    public override void _Ready()
    {
        sprite2D = GetNode<Sprite2D>("Icon");
        slider = GetNode<HSlider>("CanvasLayer/HSlider");

        slider.ValueChanged += Slider_ValueChanged;
    }

    private void Slider_ValueChanged(double value)
    {
        (sprite2D.Material as ShaderMaterial).SetShaderParameter("DissolveParameter", value);
    }
}
