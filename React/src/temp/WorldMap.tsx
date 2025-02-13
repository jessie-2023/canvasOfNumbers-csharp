import React from 'react';
import { Marks } from './Marks';
import { useWorldAtlas } from './useWorldAtlas';


const width = 960;
const height = 500;

export const WorldMap = () => {
  const data = useWorldAtlas();

  if (!data) {
    return <p>Loading...</p>;
  }

  return (
    <svg width={width} height={height}>
      <Marks data={data} />
    </svg>
  );
};

