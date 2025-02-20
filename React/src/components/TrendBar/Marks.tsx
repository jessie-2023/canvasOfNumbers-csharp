import Gap from "../../models/Gap";

export const Marks = ({
  data,
  xScale,
  yScale,
  xValue,
  yValue,
  innerHeight,
  setClickedYear
}) => {

  const handleYearClick = (d: Gap) => {
    setClickedYear(d.year); // Update state in parent
    };

  return( data.map(d => (
    <rect
      className="mark"
      key={xValue(d)}
      x={xScale(xValue(d))}
      y={yScale(yValue(d))}
      height={innerHeight-yScale(yValue(d))}
      width={xScale.bandwidth()}
      onClick={() => handleYearClick(d)}
    >
      <title>{d.year}</title>
    </rect>
  )))
}
  