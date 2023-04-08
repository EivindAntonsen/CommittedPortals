using System.Collections.Generic;

namespace CommittedPortals
{
    /// <summary>
    /// Helper class to obtain requirement arrays per biome.
    /// todo - this should be provided through configuration ideally.
    /// </summary>
    public class PortalRequirements
    {
        private static readonly Dictionary<Biomes, Piece.Requirement[]> RequirementsMap =
            new()
            {
                { Biomes.Meadows, GetMeadowsRequirements() },
                { Biomes.BlackForest, GetMeadowsRequirements() },
                { Biomes.Swamp, GetSwampRequirements() },
                { Biomes.Mountain, GetMountainRequirements() },
                { Biomes.Plains, GetPlainsRequirements() },
                { Biomes.Mistlands, GetMistlandsRequirements() },
                { Biomes.Ocean, GetMeadowsRequirements() },
                { Biomes.AshLands, GetMeadowsRequirements() },
                { Biomes.DeepNorth, GetMeadowsRequirements() }
            };

        /// <summary>
        /// Returns an array of <see cref="Piece.Requirement"/> for a specified biome.
        /// </summary>
        /// <param name="biome"></param>
        /// <returns></returns>
        public static Piece.Requirement[] GetRequirementsForBiome(int biome) =>
            RequirementsMap[(Biomes) biome];


        private static ItemDrop GetItemDrop(string prefabName) => ZNetScene
            .m_instance
            .GetPrefab(prefabName)
            .GetComponent<ItemDrop>();

        private static Piece.Requirement Requirement(string prefabName, int amount, bool recover = false) => new() { m_resItem = GetItemDrop(prefabName), m_amount = amount, m_recover = recover, m_amountPerLevel = 1 };

        private static Piece.Requirement[] GetMeadowsRequirements() => new[]
        {
            Requirement(PrefabNames.SurtlingCore, 5),
            Requirement(PrefabNames.FineWood, 35, true),
            Requirement(PrefabNames.GreydwarfEye, 40),
            Requirement(PrefabNames.AncientSeed, 5)
        };

        private static Piece.Requirement[] GetSwampRequirements() => new[]
        {
            Requirement(PrefabNames.SurtlingCore, 5),
            Requirement(PrefabNames.AncientBark, 35, true),
            Requirement(PrefabNames.Guck, 12),
            Requirement(PrefabNames.Root, 5)
        };

        private static Piece.Requirement[] GetMountainRequirements() => new[]
        {
            Requirement(PrefabNames.SurtlingCore, 5),
            Requirement(PrefabNames.FineWood, 35, true),
            Requirement(PrefabNames.Crystal, 8),
            Requirement(PrefabNames.FenrisClaw, 2)
        };

        private static Piece.Requirement[] GetPlainsRequirements() => new[]
        {
            Requirement(PrefabNames.SurtlingCore, 5),
            Requirement(PrefabNames.FineWood, 35, true),
            Requirement(PrefabNames.FulingTotem, 1),
            Requirement(PrefabNames.Tar, 15)
        };

        private static Piece.Requirement[] GetMistlandsRequirements() => new[]
        {
            Requirement(PrefabNames.SurtlingCore, 5),
            Requirement(PrefabNames.BlackCore, 2),
            Requirement(PrefabNames.YggdrasilWood, 35, true),
            Requirement(PrefabNames.RefinedEitr, 3),
        };
    }
}