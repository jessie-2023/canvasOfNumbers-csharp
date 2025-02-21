
import { useRef, useEffect, useMemo, useState } from 'react';
import { AxisX } from './AxisX';
import { AxisY } from './AxisY';
import { Marks } from './Marks';
import Gap from '../../models/Gap';
import { getGapsByCountryId } from '../../api/backendClient';
import { index, max, scaleBand, scaleLinear, scaleOrdinal, stack, union } from 'd3';
import CountryGenderGap from '../../pages/CountryGenderGap';


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

  const wideToLong = gaps
    .flatMap( g => [
      {year: String(g.year), subType: "Health", subGap: g.healthGap / 4},
      {year: String(g.year), subType: "Education", subGap: g.educationGap / 4},
      {year: String(g.year), subType: "Economic Opportunities", subGap: g.economicalGap / 4},
      {year: String(g.year),subType: "Political Power", subGap: g.politicalGap / 4},
    ])
  
  const subTypes = union(wideToLong.map(s => s.subType)) // ["Health", "Education", "Economic Opportunities", "Political Power"]

  const stacked = stack()
      .keys(subTypes)
      .value(([, group], key) => group.get(key).subGap)
    (index(wideToLong, s => s.year, s => s.subType))

  console.log(stacked)  

  const xValue = (i) => String(i + 2005)
  const xScale = scaleBand()
    .domain(wideToLong.map(d => d.year))
    .range([0, innerWidth])
    .paddingInner(0.15);
  console.log(`x: ${xValue(stacked[0], 0)}`)
  
  const yValue = s => s[1]
  const yBotValue = s => s[0]
  const yScale = scaleLinear()
    .domain([0, 0.892]) // replace hard coding with max() later
    .range([innerHeight, 0]);
  console.log(`y: ${yValue(stacked[0], 0)}`)

  const colorValue = (j) => ["Health", "Education", "Economic Opportunities", "Political Power"][j];
  const colorScale = scaleOrdinal()
    .domain(["Health", "Education", "Economic Opportunities", "Political Power"]) 
    .range(["#BA5F06", "#BD8F22", "#F6B656", "#F2DA57"])
  console.log(`color: ${colorValue(stacked[0])}`)
  
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
          stacked={stacked}
          xScale={xScale}
          yScale={yScale}
          colorScale={colorScale}
          xValue={xValue}
          yValue={yValue}
          yBotValue={yBotValue}
          colorValue={colorValue}
          innerHeight={innerHeight}
          setClickedYear={setClickedYear}
        />
      </g>
    </>);
};
