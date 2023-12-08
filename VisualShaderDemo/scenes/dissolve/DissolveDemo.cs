using Godot;
using System;

public partial class DissolveDemo : Sprite2D
{
    HSlider hSlider;

    public override void _Ready()
    {
        hSlider = GetNode<HSlider>("../CanvasLayer/HSlider");
        hSlider.ValueChanged += HSlider_ValueChanged;
    }

    private void HSlider_ValueChanged(double value)
    {
        ShaderMaterial shaderMaterial = this.Material as ShaderMaterial;
        if (shaderMaterial != null)
        {
            shaderMaterial.SetShaderParameter("AlphaValue", hSlider.Value);
        }
    }

}
