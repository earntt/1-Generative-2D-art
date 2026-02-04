
#version 330 core
out vec4 FragColor;

in vec2 TexCoord;

uniform sampler2D texture1;
uniform sampler2D texture2;
uniform float time; // Receive time from C++

void main()
{
    // Animate the mix value using sine between 0.0 and 1.0
    float mixValue = (sin(time) + 1.0) / 2.0; 
    FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), mixValue);
}