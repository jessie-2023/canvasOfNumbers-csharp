import { geoNaturalEarth1, geoPath, geoGraticule } from 'd3';
import WorldAltas from '../models/WorldAtlas';

const projection = geoNaturalEarth1();
const path = geoPath(projection);
const graticule = geoGraticule();


export const Marks = ({ data }: { data: WorldAltas }) => 
{
  if (!data || !data.interiors || !data.countries.features) {
    console.log("data fetch failure")
    return <p>loading</p>; // or show a loading message
  }

  return (
  <g className="marks">
    <path className="sphere" d={path({ type: 'Sphere' })} />
    <path className="graticules" d={path(graticule())} />
    {data.countries.features.map(feature => (
      <path className="land" d={path(feature)} />
    ))}
    <path className="interiors" d={path(data.interiors)} />
  </g>
);
}
