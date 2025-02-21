import Gap from "../../models/Gap";

export const Marks = ({
  stacked,
  xScale,
  yScale,
  colorScale,
  xValue,
  yValue,
  yBotValue,
  colorValue,
  innerHeight,
  setClickedYear
}) => {

  const handleYearClick = (i) => {
    setClickedYear(Number(xValue(i))); 
    };
  
  
    return (
      stacked.map((subIndex, j) => (
        subIndex.map((s, i) => {
          // Calculate the y position for the stacked bar
      const yBot = j === 0 ? 0 : stacked[j - 1][i][1];
      const yTop = s[1];

      // Calculate the height of each sub-bar
      const height = innerHeight - yScale(yTop - yBot);

          console.log(`x: ${xScale(xValue(i))}`);
          console.log(`y: ${yScale(yValue(s))}`);
          console.log(`y: ${yScale(yBotValue(s))}`);
          console.log(`color: ${colorScale(colorValue(j))}`);
          
          return (
            <rect
              className="mark"
              key={`${xValue(i)}-${colorValue(j)}`}
              x={xScale(xValue(i))}
              y={yScale(yTop)}
              height={height}
              width={xScale.bandwidth()}
              fill={colorScale(colorValue(j))}
              onClick={() => handleYearClick(i)}
            >
              <title>{xValue(i)}</title>
            </rect>
          );
        })
      ))
    );
}
  