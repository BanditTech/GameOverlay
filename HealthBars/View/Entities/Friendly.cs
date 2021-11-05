namespace HealthBars.View.Entities
{
    using Controller;

    /// <inheritdoc />
    public class Friendly : CommonFriendly
    {
        /// <inheritdoc />
        public override void Draw(EntityParams eP, SpriteController spriteController)
        {
            var scale = RarityBarScale(eP);

            AddEmptyBar(spriteController, eP, scale);
            AddHealthBar(spriteController, eP, scale);
            if (eP.EsTotal > 0)
            {
                AddEnergyShieldBar(spriteController, eP, scale);
            }
        }

        /// <inheritdoc />
        public override bool ShouldDraw(EntityParams entityParams)
        {
            return entityParams.Settings.ShowFriendlyBars;
        }


        private static float RarityBarScale(EntityParams entityParams)
        {
            return entityParams.Settings.FriendlyBarScale;
        }
    }
}