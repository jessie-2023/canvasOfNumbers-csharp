export const AxisX = ({ xScale, innerHeight }) =>
  xScale.domain().map(tickValue => (
    <g className="tick">
      <text
        key={tickValue}
        style={{ textAnchor: 'end' }}
        y={0}
        dx=".71em" 
        x={xScale(tickValue) + xScale.bandwidth() / 2}
      >
        {tickValue}
      </text>
    </g>
  ));

  