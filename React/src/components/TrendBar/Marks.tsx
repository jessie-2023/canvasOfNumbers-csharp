export const Marks = ({
  data,
  xScale,
  yScale,
  xValue,
  yValue,
  innerHeight,
}) =>
  data.map(d => (
    <rect
      className="mark"
      key={xValue(d)}
      x={xScale(xValue(d))}
      y={yScale(yValue(d))}
      height={innerHeight-yScale(yValue(d))}
      width={xScale.bandwidth()}
    >
      <title>{data.CountryName}</title>
    </rect>
  ));
