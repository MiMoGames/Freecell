Get-ChildItem "." -Filter *.png | `
Foreach-Object{
    $filename = $_.Name
	echo $filename
#	$command = "convert $filename ( +clone -background black  -shadow 100x8+0+0 -channel A -level 0,50% +channel ) +swap -background none -layers merge +repage -resize 110x160 output\$filename"
	$command = "convert $filename ( +clone -background black  -shadow 100x3+0+0 -channel A -level 0,50% +channel ) +swap -background none -layers merge +repage -resize 110x160 output\$filename"
	echo $command
	cmd.exe /c $command
}
