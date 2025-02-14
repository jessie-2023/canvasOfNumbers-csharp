import { useEffect, useState } from 'react';
import { feature, mesh } from 'topojson';
import { GeometryObject, Topology } from "topojson-specification";
import { FeatureCollection } from "geojson";
import { Marks } from './Marks';
import WorldAtlas from '../../models/WorldAtlas';
import getWorldAtlas from '../../api/worldAtlasClient';
import Gap from '../../models/GapGeneral';
import { getGeneralByYear } from '../../api/backendClient';
import GenderGap from '../../pages/GenderGap';
import { scaleSequential } from 'd3-scale';
import { interpolateCubehelixDefault as colorGradience, max, min } from 'd3';

const width = 960;
const height = 500;
const year = 2019;
export const WorldMap = () => {
    const [world, setWorld] = useState<WorldAtlas>();
    const [gaps, setGaps] = useState<Gap[]>();
    
    useEffect(() => {
        getWorldAtlas().then((topology: Topology) => {
          const topoCountries = topology.objects.countries;
          setWorld({
            countries: feature(topology, topoCountries) as FeatureCollection, // transforms TopoJSON country data into a GeoJSON FeatureCollection
            interiors: mesh(topology, topoCountries as GeometryObject, (a, b) => a !== b) // extracts only the shared boundaries (like country borders) from a TopoJSON object
        })});
    }, []);

    useEffect(() => {
      getGeneralByYear(year)
        .then(data => setGaps(data))
    }, []);


  if (!world || !gaps || !gaps.length) {
    return <p>Loading...</p>;
  }

  const mapByCountry = new Map();
  gaps.forEach(country => mapByCountry.set(country.countryId, country)) 

  const colorValue = (gap: Gap) => gap.generalGap;
  const colorScale = scaleSequential(colorGradience).domain([
    // min(gaps, colorValue)!,
    0.3,
    max(gaps, colorValue)! // promise min & max are NOT undefined
  ])
  
  return (
    <svg width={width} height={height}>
      <Marks 
        world={world} 
        mapByCountry={mapByCountry}
        colorScale={colorScale}
        colorValue={colorValue}

      />
    </svg>
  );
};

