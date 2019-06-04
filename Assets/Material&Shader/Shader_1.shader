Shader "Custom/Shader_1" {
	Properties {
		_MainTex("MainTex",2D)="white"{}
	}
	CGINCLUDE
	#include "UnityCG.cginc"

	float box(float2 st, float size)
	{
    	size = 0.5 + size * 0.3;
    	st = step(st, size) * step(1.0 - st, size);
    	return st.x * st.y;
	}
	float rand(float2 st)
	{
    	return frac(sin(dot(st, float2(12.9898, 78.233))) * 43758.5453);
	}

	float wave(float2 st, float n)
	{
  	  	st = (floor(st * n) + 0.5) / n;
  	  	float d = distance(0, st);
   	 	//return (1 + sin(d * 3 - _Time.y * 3)) * 0.5;
   	 	float offs=rand(st)*2;
   	 	return (1 + sin(d*3-_Time.y * 5)) * 0.5;
	}
	float box_wave(float2 uv, float n)
	{
    	float2 st = frac(uv * n);
    	float size = wave(uv, n);
    	return box(st, size);
	}

	float4 frag(v2f_img i) : SV_Target
	{
		return float4(0,box_wave(i.uv, 12)*0.7,box_wave(i.uv,10)*1,1);
	}
	ENDCG

	SubShader {
		Pass
		{
		CGPROGRAM
		#pragma vertex vert_img
		#pragma fragment frag
		ENDCG
		}
	}
}
