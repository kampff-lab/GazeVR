#version 400
uniform mat4 modelview;
uniform mat4 projection;
uniform vec2 scale = vec2(1, 1);
uniform vec2 shift;
layout(location = 0) in vec2 vp;
layout(location = 1) in vec2 vt;
out vec2 texCoord;

void main()
{
  vec4 v = modelview * vec4(vp * scale + shift, 0.0, 1.0);
  gl_Position = projection * v;
  texCoord = vt;
}