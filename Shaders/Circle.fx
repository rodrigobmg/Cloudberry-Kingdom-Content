#include "RootEffect.fx"

Texture xTexture;
sampler TextureSampler = sampler_state { texture = <xTexture>; };

PixelToFrame CirclePixelShader(VertexToPixel PSIn)
{
    PixelToFrame Output = (PixelToFrame)0;
    
    float d = (PSIn.TexCoords.x - .5) * (PSIn.TexCoords.x - .5) + (PSIn.TexCoords.y - .5) * (PSIn.TexCoords.y - .5);
    float4 baseColor = tex2D(TextureSampler, PSIn.TexCoords);
    
    Output.Color = PSIn.Color;
    //Output.Color *= baseColor;
	
	Output.Color.a *= saturate(100*(.25 - d));
    //Output.Color *= PSIn.Color;

	// Premultiply the alpha
	Output.Color.rgb *= Output.Color.a;
	        
    return Output;
}

technique Simplest
{
    pass Pass0
    {
        VertexShader = compile VERTEX_SHADER SimplestVertexShader();
        PixelShader = compile PIXEL_SHADER CirclePixelShader();
    }
}