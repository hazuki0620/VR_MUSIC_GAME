Shader "Custom/Shader_2" {
	Properties {
		_MainTex("MainTex",2D)="white"{}
	}
	CGINCLUDE
	#include "UnityCG.cginc"
	float box(float2 st, float size)
	{
    	size = 0.5 + size * 0.5;
    	st = step(st, size) * step(1.0 - st, size);
    	return st.x * st.y;
	}

	float wave(float2 st,float n)
	{
		st = (floor(st * n) + 0.5) / n;
		float d = distance(0.5, st);
    	return (1 + sin(d * 3 -_Time.y * 3)) * 0.5;
	}
	float4 frag(v2f_img i) : SV_Target
	{
		float n=10;
		float st=frac(i.uv*n);
		float size = wave(i.uv, n);
    	return box(st, size);
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
