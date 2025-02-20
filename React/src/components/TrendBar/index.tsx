
import { useRef, useEffect, useMemo, useState } from 'react';
import { AxisX } from './AxisX';
import { AxisY } from './AxisY';
import { Marks } from './Marks';
import Gap from '../../models/Gap';
import { getGapsByCountryId } from '../../api/backendClient';
import { max, scaleBand, scaleLinear } from 'd3';


const margin = { top: 10, right: 200, bottom: 15, left: 200 };
const xAxisLabelOffset = 54;
const yAxisLabelOffset = 30;
// const xAxisTickFormat = timeFormat('%m/%d/%Y');

const xAxisLabel = 'Year';
const yAxisLabel = 'General Gender Gap';

export const TrendBar = ({width, height, selectedCountry, setClickedYear}) => {
  
  const [gaps, setGaps] = useState<Gap[]>();

  useEffect(() => {
    getGapsByCountryId(selectedCountry)
          .then(data => setGaps(data))
      }, [selectedCountry]);
  
  if (!gaps) {
    return <pre>Loading...</pre>;
  }
  
  const innerHeight = height - margin.top - margin.bottom;
  const innerWidth = width - margin.left - margin.right;

  const xValue = (gap: Gap) => String(gap.year);
  const xScale = scaleBand()
    .domain(gaps.map(xValue))
    .range([0, innerWidth])
    .paddingInner(0.15);

  const yValue = (gap: Gap) => gap.generalGap as number;
  const yScale = scaleLinear()
    .domain([0, 0.892]) // replace hard coding with max() later
    .range([innerHeight, 0]);

  return (<>
    <rect width={width} height={height} fill="red" opacity={0.1} />
      <g transform={`translate(${margin.left},${margin.top})`}>
        <AxisX
          xScale={xScale}
          innerHeight={innerHeight}
        />
        <AxisY yScale={yScale} innerWidth={innerWidth} tickOffset={5}/>
        <text
          className="axis-label"
          textAnchor="middle"
          transform={`translate(${-yAxisLabelOffset},${innerHeight /
            2}) rotate(-90)`}
        >
          Gender Gap in {gaps[0].countryName}
        </text>
        <Marks
          data={gaps}
          xScale={xScale}
          yScale={yScale}
          xValue={xValue}
          yValue={yValue}
          innerHeight={innerHeight}
          setClickedYear={setClickedYear}
        />
      </g>
    </>);
};
