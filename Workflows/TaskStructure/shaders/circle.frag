#version 400
in vec2 texCoord;
out vec4 fragColor;
uniform vec4 color = vec4(1);
const vec2 center = vec2(0.5,0.5);

void main()
{
  float intensity = length(texCoord - center) < 0.5 ? 1.0 : 0.0;
  fragColor = color * intensity;
}
