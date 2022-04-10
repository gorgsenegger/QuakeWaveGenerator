# QuakeWaveGenerator

## Disclaimer
🔴**This is still work in progress, the path_corner entities are not done yet**🔴

A Winforms application to automate the creation of multiple `func_train` "blocks", laid out in a horizontal grid where you can configure the number of "rows" and "columns". The blocks only move horizontally and, by timing the amplitudes of that movement, give the impression of a wave. The output of this program will be in the format as required by the Quake map file specifications, e.g.

```
{
  "classname" "func_train"
  "dmg" "0"
  "speed" "32"
  "sounds" "0"
  "target" "train_row-002_column-002_init"
  {
    (68 68 64) (68 68 0) (68 132 64) METAL1_3 0 0 0 1 1
    (132 132 64) (132 132 0) (132 68 64) METAL1_3 0 0 0 1 1
    (132 68 64) (132 68 0) (68 68 64) METAL1_3 0 0 0 1 1
    (68 132 64) (68 132 0) (132 132 64) METAL1_3 0 0 0 1 1
    (68 132 0) (68 68 0) (132 132 0) METAL1_3 0 0 0 1 1
    (132 68 64) (68 68 64) (132 132 64) METAL1_3 0 0 0 1 1
}
{
  "classname" "path_corner"
  "targetname" "train_row-002_column-002_init"
  "target" "train_row-002_column-002_bottom"
  "origin" "68 68 0"
}
{
  "classname" "path_corner"
  "targetname" "train_row-002_column-002_bottom"
  "target" "train_row-002_column-002_top"
  "origin" "68 68 0"
}
{
  "classname" "path_corner"
  "targetname" "train_row-002_column-002_top"
  "target" "train_row-002_column-002_bottom"
  "origin" "68 68 0"
}
```

# Options
You can configure (in Quake units):
- the side length of the blocks that are created
- the spacing between them
- the number of them (the product of the number of rows and columns)
- the offsets for x, y and z coordinates
- the amplitude of the wave
- the number of steps between 0 and the amplitude
- damage (if any), speed (of the `func_train` and sound (if any) -> these are the properties of the `func_train` entity
- the texture to be used

# Example
A Picture (or video...) says more than a thousand words:

[Example video](QuakeWaveGenerator.mp4)